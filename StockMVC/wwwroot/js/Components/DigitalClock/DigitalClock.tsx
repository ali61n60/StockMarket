import * as React from "react";

interface Props {
    
}

interface State {
    date: Date;
}

export default class DigitalClock extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state={date:new Date()}
    }
    divStyle = {
        color: 'white',
        textAlign: "center",
        borderWidth:"10px",
        borderStyle: "solid",
        borderColor: "green",
        borderRadius: "30px"
    } as const;

    timerId: any;

    tick=()=>  {
        this.setState({
            date: new Date()
        });
    }

    componentDidMount() {
        this.timerId = setInterval(() => this.tick(), 1000);
    }

    componentWillUnmount() {
        clearInterval(this.timerId);
    }

    render() {
        return (<div className="bg-primary" style={this.divStyle}>
            <h1>DigitalClock</h1>
            <h2>{this.state.date.toLocaleTimeString()}</h2>
        </div>);
    }
}

