import {ITree} from "../../Interfaces/Inspector/ITree";
import {TreeNodes} from "../../Interfaces/Inspector/TreeNodes";
import {ITreeBase} from "../../Interfaces/Inspector/ITreeBase";
import $ from "jquery";
import {INode} from "../../Interfaces/Inspector/INode";
import {deepEqual} from "../../Util/deepEqual";
import {InspectorClickType} from "../../Interfaces/Inspector/IInspectorClickType";

export class InspectorService {
    public tree: ITree;
    public prevTree: ITree;
    public textModeIsEnabled: boolean;

    public onClickNodeCallback: (node: INode) => void;

    public onClickCoordinatesCallback: (x: number, y: number) => void;

    public clickType: InspectorClickType = "node";

    constructor(onClickNodeCallback: (node: INode) => void, onClickCoordinatesCallback: (x: number, y: number) => void) {
        this.onClickNodeCallback = onClickNodeCallback;
        this.onClickCoordinatesCallback = onClickCoordinatesCallback;

        this.prevTree = {} as ITree;
        this.tree = {} as ITree;
        this.textModeIsEnabled = false;
    };

    setTree(tree: ITree | null) {
        if (!tree) {
            this.tree = {} as ITree;
            return;
        }

        this.prevTree = this.tree;
        this.tree = tree;
    }

    setOnClickNodeCallback(onClickNodeCallback: (node: INode) => void): void {
        this.onClickNodeCallback = onClickNodeCallback;
    };

    setOnClickCoordinatesCallback(onClickCoordinatesCallback: (x: number, y: number) => void): void {
        this.onClickCoordinatesCallback = onClickCoordinatesCallback;
    };

    setType(type: InspectorClickType): void {
        this.clickType = type;
    }

    setTextModeIsEnabled(isEnabled: boolean) {
        this.textModeIsEnabled = isEnabled;
    }

    formatTree(tree: ITree, index: number = 0, xpath: string = "/"): void {
        tree.node.xpath = (xpath) + "/" + tree.node.cls + "[" + index + "]" +
            (tree.node.id ? "[@resource-id='" + tree.node.id + "']" : "") +
            (tree.node.text ? "[@text='" + tree.node.text + "']" : "") +
            (tree.node.desc ? "[@content-desc='" + tree.node.desc + "']" : "");

        tree.node.index = index;

        tree.node.bounds.centerX = (tree.node.bounds.left + tree.node.bounds.right) / 2;

        tree.node.bounds.centerY = (tree.node.bounds.top + tree.node.bounds.bottom) / 2;

        tree.node.bounds.width = tree.node.bounds.right - tree.node.bounds.left;

        tree.node.bounds.height = tree.node.bounds.bottom - tree.node.bounds.top;

        if (tree.children) {
            let i = 0;
            tree.children.forEach((element) => {
                this.formatTree(element, i, tree.node.xpath);
                i++;
            });
        }
    }

    treeToList(tree: ITree): TreeNodes {
        const treeNodes: TreeNodes = {};

        treeNodes[tree.node.hash] = tree.node;

        if (tree.children) {
            tree.children.forEach((element) => {
                const children = this.treeToList(element);
                for (const key in children) {
                    if (Object.prototype.hasOwnProperty.call(children, key)) {
                        treeNodes[key] = children[key];
                    }
                }
            });
        }

        return treeNodes;
    }

    genRange(tree: ITree, scale: number, base: ITreeBase = {} as ITreeBase): JQuery<HTMLElement> {
        const nodeDOM = $("#screen .node");

        if (nodeDOM) {
            nodeDOM.remove();
        }

        const nodeText = tree.node.text || tree.node.desc;

        const $dom = $(`<div class="node" 
                          id="rnode-${tree.node.hash}" 
                          data-hash="${tree.node.hash}" 
                          data-cls="${tree.node.cls}" 
                          data-id="${tree.node.id}"
                          data-left="${tree.node.bounds.left}"
                          data-top="${tree.node.bounds.top}"
                          data-text="${tree.node.text}"
                          style="${this.textModeIsEnabled && tree.node.isVisibleToUser && nodeText.length > 0 ? "border: 1px solid red" : ""}"
                          >
                              ${this.textModeIsEnabled && tree.node.isVisibleToUser ? `<span>${nodeText}</span>` : ""}
                          </div>
                    `);
        const baseTop = (base && base.top) || 0;
        const baseLeft = (base && base.left) || 0;
        const baseLv = (base && base.lv) || 0;

        $dom.css({
            top: (tree.node.bounds.top - baseTop) * scale + "px",
            left: (tree.node.bounds.left - baseLeft) * scale + "px",
            width: (tree.node.bounds.right - tree.node.bounds.left) * scale + "px",
            height: (tree.node.bounds.bottom - tree.node.bounds.top) * scale + "px",
        });

        $dom.addClass("node" + baseLv);

        if (tree.children) {
            tree.children.forEach((element) => {
                $dom.append(
                    this.genRange(element, scale, {
                        top: tree.node.bounds.top,
                        left: tree.node.bounds.left,
                        lv: baseLv + 1,
                    }),
                );
            });
        }

        return $dom;
    }

    genTree(tree: ITree, base: ITreeBase = {} as ITreeBase): any {
        $("#tree").html("");

        const $dom = $(
            `<div class="node" id="tnode-${tree.node.hash}" data-hash="${tree.node.hash}">
                <span class="name">
                    cls(${tree.node.cls})
                    ${tree.node.id ? ".id(" + tree.node.id + ")" : ""}
                    ${tree.node.text ? ".text(" + tree.node.text + ")" : ""}
                    ${tree.node.desc ? ".desc(" + tree.node.desc + ")" : ""}
                </span>
            </div>`,
        );
        const baseLv = (base && base.lv) || 0;
        $dom.addClass("node" + baseLv);
        if (baseLv == 0) {
            $dom.css("display", "block");
        }
        if (!tree.node.isVisibleToUser) {
            $dom.addClass("invisible");
        }
        if (tree.children) {
            $dom.addClass("descendants");
            tree.children
                .forEach((element: any) => {
                    $dom.append(
                        this.genTree(element, {
                            lv: baseLv + 1,
                        }),
                    );
                });
        }
        return $dom;
    }

    renderWithCatch(): void {
        const screen = $("#screen");
        const screenImg = $("#screen>img");
        const container = $("#container");
        const treeDOM = $("#tree");

        const screenHeight = screenImg.height();

        const scale = screenHeight ? screenHeight / this.tree.node.bounds.bottom : 1;

        screenImg.css({
            height: screenImg.height() + "px",
        });

        screen.css({
            height: screen.height() + "px",
        });

        container.css({
            height: container.outerHeight() + "px",
        });

        $("#panel1").css({
            "width": screen.width() + "px",
        });

        $("#prepare-mask").hide();

        this.formatTree(this.tree);

        const treeNodes = this.treeToList(this.tree);

        screen.append(this.genRange(this.tree, scale));

        treeDOM.html(this.genTree(this.tree));

        screen.off("click");

        const onMouseEvent = (e: any) => {
            $("#screen .node").removeClass("hover");
            $("#tree .node").removeClass("hover expand");

            for (const key in treeNodes) {
                if (Object.prototype.hasOwnProperty.call(treeNodes, key)) {
                    const bounds = treeNodes[key].bounds;

                    if (e.offsetX) {
                        localStorage.setItem("offsetX", e.offsetX);
                    }

                    if (e.offsetY) {
                        localStorage.setItem("offsetY", e.offsetY);
                    }

                    const offsetX = e.offsetX || localStorage.getItem("offsetX");

                    const offsetY = e.offsetY || localStorage.getItem("offsetY");

                    if (bounds.left * scale < offsetX && offsetX < bounds.right * scale &&
                        bounds.top * scale < offsetY && offsetY < bounds.bottom * scale) {
                        const rNode = $("#rnode-" + key);
                        const tNode = $("#tnode-" + key);

                        if (!rNode.is(".node0")) {
                            rNode.addClass("hover");
                            tNode.addClass("hover");
                        }
                        tNode.parents(".node").removeClass("hover").add(tNode).addClass(
                            "expand");
                    }
                }
            }
        };

        screen.on("mousemove", function(e) {
            onMouseEvent(e);
        });

        screen.trigger("mousemove");

        screen.mouseleave(function() {
            const treeCurrent = $("#tree .current");
            $("#tree .node").removeClass("hover expand");
            treeCurrent.parents(".node").add(treeCurrent).addClass("expand");
        }).click((e) => {
            $("#screen .node").removeClass("current");
            $("#tree .node").removeClass("current expand");
            const array: INode[] = [];

            for (const key in treeNodes) {
                if (Object.prototype.hasOwnProperty.call(treeNodes, key)) {
                    const bounds = treeNodes[key].bounds;
                    if (bounds.left * scale < e.offsetX && e.offsetX < bounds.right * scale &&
                        bounds.top * scale < e.offsetY && e.offsetY < bounds.bottom * scale) {
                        const rNode = $("#rnode-" + key);
                        const tNode = $("#tnode-" + key);

                        if (!rNode.is(".node0")) {
                            rNode.addClass("current");
                            tNode.addClass("current");
                        }
                        rNode.parents(".node").removeClass("current");
                        tNode.parents(".node").removeClass("current").add(tNode).addClass(
                            "expand");

                        array.push(treeNodes[key]);
                    }
                }
            }

            const selectedNode = array[array.length - 2];

            if (this.clickType === "node") {
                this.onClickNodeCallback(selectedNode);
            } else {
                this.onClickCoordinatesCallback(e.offsetX / scale, e.offsetY / scale);
            }
        });

        treeDOM.mouseleave(function() {
            $("#tree .node").removeClass("hover");
        }).on("mouseover", ".node", function(e) {
            e.stopPropagation();
            $("#screen .node").removeClass("hover");
            $("#tree .node").removeClass("hover");
            $(this).addClass("hover");
            $("#rnode-" + $(this).data("hash")).addClass("hover");
        }).on("click", ".node", function(e) {
            e.stopPropagation();
            $("#screen .node").removeClass("current");
            $("#tree .node").removeClass("current expand");
            $(this).addClass("current");
            $("#rnode-" + $(this).data("hash")).addClass("current");
            $(this).parents(".node").add(this).addClass("expand");
        });
    }

    render(): void {
        try {
            if (deepEqual(this.prevTree, this.tree)) {
                this.renderWithCatch();
            }
        } catch (error) {
            console.log(error);
        }

        const elem = document.getElementById("screen");

        console.log(this.clickType);

        elem?.dispatchEvent(new Event("mousemove"));
    }
}

