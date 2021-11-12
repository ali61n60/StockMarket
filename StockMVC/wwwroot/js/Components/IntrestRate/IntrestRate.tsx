import * as React from "react";

interface Props { }

interface State {
    isToggleOn: boolean;
}

export default class IntrestRate extends React.Component<Props,State > {
    constructor(props) {
        super(props);
        this.state = { isToggleOn: true };
    }
   
    handleClick=()=> {
        this.setState((prevState) => ({
            isToggleOn: !prevState.isToggleOn
        }));
    }

    render() {
        const className = "btn btn-block btn-primary";
        return (
            <button className={className} onClick={this.handleClick}>
                {this.state.isToggleOn ? 'ON' : 'OFF'}
            </button>
        );
    }
}

