import * as React from "react";

interface Props { }

interface State {
    isToggleOn: boolean;
}

export default class ToggleButton extends React.Component<Props,State > {
    constructor(props) {
        super(props);
        this.state = { isToggleOn: true };

       
       
    }
    //<button onClick={(e) => this.deleteRow(id, e)}>Delete Row</button>
    //<button onClick={this.deleteRow.bind(this, id)}>Delete Row</button>

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

