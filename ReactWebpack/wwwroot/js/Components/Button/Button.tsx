import * as React from "react";

interface Props {
    type:"primary"|"default";
}
interface State {
    buttonClicked: boolean;
}

export default class Button extends React.Component<Props, State> {
    i: number=0;
    constructor(props: Props) {
        super(props);
        this.state = { buttonClicked: false };
        
    }
    
    render() {
        const className = this.props.type === "primary" ?
            "btn btn-block btn-primary" : "btn btn-block btn-danger";
        return (
            <React.Fragment>
                <p className="text-center">number is: {this.i}</p>
                <button className={className} onClick={this.handleClick}>{this.props.children}</button>
            </ React.Fragment>
        );
    }

    handleClick = () => {
        this.i++;
        this.setState({ buttonClicked: true });
    }
}


