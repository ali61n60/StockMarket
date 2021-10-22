import * as React from "react";
import axios from "axios";
import Chart from "chart.js/auto";
import PointData from "../.././Models/PointData";

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

     chartRef = React.createRef() as any; 

    componentDidMount(): void {
        const myChartRef = this.chartRef.current.getContext("2d");
        
        
       

        //TODO get symbol data from server based on symbolId
        //GetSymbolTradeData
        //http://localhost:2333/api/symbol/sayhello?name=Ali%20Nejati
        axios.get("http://localhost:2333/api/symbol/GetSymbolTradeData?symbolId=1").then(response => {
            console.log(response.data);
            let PointDataArray: [PointData] = response.data as [PointData];
            console.log(PointDataArray);
            const data = {
                labels: [

                ],
                datasets: [{
                    label: 'My First dataset',
                    backgroundColor: 'rgb(255, 99, 132)',
                    borderColor: 'rgb(255, 99, 132)',
                    data: [],
                }]
            };
            for (var i = 0; i < PointDataArray.length; i++) {
                data.labels.push(PointDataArray[i].Date);
                data.datasets[0].data.push(PointDataArray[i].Final);
            }
            const config = {
                type: 'line',
                data: data,
                options: {}
            };

            new Chart(myChartRef, config as any);
        });


        
    }

    render() {
        const className = "btn btn-block btn-danger";
        
         
        return (
            <React.Fragment>
                <h1 id="h1">ChartDraw</h1>
                <h2>Symbold Id: {this.props.SymbolId}</h2>
                <h3>Counter: {this.state.counter}</h3>
                <button className={className} onClick={this.handleAddClick}>Add</button>
                <button className={className} onClick={this.handleMinusClick}>Minus</button>
                <canvas id="chart1" ref={this.chartRef}/>
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