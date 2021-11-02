import * as React from "react";
import axios from "axios";
import Chart from "chart.js/auto";
import PointData from "../.././Models/PointData";

interface Props { 
    SymbolId: number;
}
interface State {
    
}

export default class ChartDraw extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.mounted = false;
    }
    chartRef = React.createRef() as any; 
    mounted: boolean;
    myChart: Chart;
    draw() {
      if (this.mounted) {
            this.myChart.destroy();
        }
        const myChartRef = this.chartRef.current.getContext("2d");
        //Get symbol data from server based on symbolId   http://localhost:2333
        axios.get(`/api/symbol/GetSymbolTradeData?symbolId=${this.props.SymbolId}`).then(response => {
            let PointDataArray: [PointData] = response.data as [PointData];
            const data = {
                labels: [],
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
            this.myChart= new Chart(myChartRef, config as any);
        });
    }

    componentDidMount(): void {
        console.log(`Didmount for ${this.props.SymbolId}`);
        this.draw();
        this.mounted = true;
    }

    render() {
        console.log(`Render for ${this.props.SymbolId}`);        
        if (this.mounted) {
            this.draw();
        }
        return (
            <React.Fragment>
                <h2>Symbold Id: {this.props.SymbolId}</h2>
                <canvas id="chart1" ref={this.chartRef}/>
            </ React.Fragment>
        );        
    }
}