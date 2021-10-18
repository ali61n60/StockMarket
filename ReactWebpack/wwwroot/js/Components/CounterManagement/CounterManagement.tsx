import * as React from "react";

interface Props {
    ownerName: string;
    CustomCallBack(currentNumber:number);

}
interface State {
    counter: number;

}

export default class CounterManagement extends React.Component<Props, State> {
    i: number=0;
    constructor(props: Props) {
        super(props);
        this.state = { counter: 0 }
    }

    render() {
        const className = "btn btn-block btn-danger";
        return (
            <React.Fragment>
                <h1>Counter Management</h1>
                <h2>Owner Name: {this.props.ownerName}</h2>
                <h3>Counter: {this.state.counter}</h3>
                <button className={className} onClick={this.handleAddClick}>Add</button>
                <button className={className} onClick={this.handleMinusClick}>Minus</button>
            </ React.Fragment>
        );
    }

    handleAddClick = () => {
        this.setState({ counter: this.state.counter + 1 });
        
    }

    handleMinusClick = () => {
        this.setState({ counter: this.state.counter - 1 });
        this.props.CustomCallBack(this.state.counter);
    }
}


