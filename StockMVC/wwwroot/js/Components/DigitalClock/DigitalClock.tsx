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
        color: "#2d6a4f",
        textAlign: "center",
        borderWidth:"10px",
        borderStyle: "solid",
        borderColor: "#FDE2E4",
        borderRadius: "30px",
        backgroundColor:"#BEE1E6"
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
        return (<div className="" style={this.divStyle}>            
            <h2>{this.state.date.toLocaleTimeString()}</h2>
        </div>);
    }
}

