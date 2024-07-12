/**
 * Copyright (c) 2017-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

const React = require("react");
const Redirect = require("../../core/Redirect.js");

const siteConfig = require(process.cwd() + "/siteConfig.js");

function docUrl(doc, language) {
    return (
        siteConfig.baseUrl +
        "docs/" +
        (language ? language + "/" : "") +
        doc +
        ".html"
    );
}

class Index extends React.Component {


    render() {
        return (
            <Redirect
                redirect={docUrl("dispatcher", this.props.language)}
                config={siteConfig}
            />
        );
    }
}


module.exports = Index;

