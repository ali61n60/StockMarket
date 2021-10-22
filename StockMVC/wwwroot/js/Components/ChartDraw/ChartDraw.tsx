import * as React from "react";
import { Chart } from "chart.js";
 

interface Props {
    SymbolId: number;
    CustomCallBack(message: string);

}
interface State {
    counter: number;
}

export default class ChartDraw extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state = { counter: 0 }

    }

    render() {
        const className = "btn btn-block btn-danger";
        //TODO get symbol data from server based on symbolId
        const data = {
            labels: [
                'January',
                'February',
                'March',
                'April',
                'May',
                'June',
            ],
            datasets: [{
                label: 'My First dataset',
                backgroundColor: 'rgb(255, 99, 132)',
                borderColor: 'rgb(255, 99, 132)',
                data: [0, 10, 5, 2, 20, 30, 45],
            }]
        };
        const config = {
            type: 'line',
            data: data,
            options: {}
        };
       
       
        //let myChart = new Chart(
        //    document.getElementById("chart1") as HTMLCanvasElement, config as any
        //);
         
        return (
            <React.Fragment>
                <h1>ChartDraw</h1>
                <h2>Symbold Id: {this.props.SymbolId}</h2>
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
        this.props.CustomCallBack(this.state.counter.toString());
    }
}