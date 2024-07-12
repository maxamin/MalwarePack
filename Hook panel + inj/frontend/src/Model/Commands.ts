
export interface CommandsProps {
    name: string,
    icon: any,
    action: () => void,
    isDanger?: boolean,
    type?: string,
    quickAccess?: boolean,
    hideInMultiSelect?: boolean,
}

export interface LogButtonsProps extends CommandsProps {
    hasAccess: boolean,
}
