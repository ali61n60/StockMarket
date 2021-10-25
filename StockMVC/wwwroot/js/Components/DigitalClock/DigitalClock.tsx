import * as React from "react";

interface Props { }

interface State {
    liked: boolean;
}

export default class DigitalClock extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state = { liked: false };
    }
    divStyle = {
        color: 'white',
        textAlign: "center",
        borderWidth:"10px",
        borderStyle: "solid",
        borderColor: "green",
        borderRadius: "30px"
    } as const;

    render() {
        return (<div className="bg-primary" style={this.divStyle}>
            <h1>DigitalClock</h1>
            <h2>{new Date().toLocaleTimeString()}</h2>
        </div>);
    }
}

