import * as React from "react";
import Chart from "chart.js/auto";
import PointData from "../../Models/PointData";

interface Props { 
    PointDataArray: PointData[];
}
interface State {}

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
       
            const data = {
                labels: [],
                datasets: [{
                    label: 'My First dataset',
                    backgroundColor: 'rgb(255, 99, 132)',
                    borderColor: 'rgb(255, 99, 132)',
                    data: [],
                },
                    {
                        label: 'ConstLine',
                        backgroundColor: 'rgb(0, 99, 255)',
                        borderColor: 'rgb(255, 99, 132)',
                        data: [],
                    }
                ]
            };
        for (let i = 0; i < this.props.PointDataArray.length; i++) {
            data.labels.push(this.props.PointDataArray[i].Date);
            data.datasets[0].data.push(this.props.PointDataArray[i].Final);
            //data.datasets[1].data.push(1.2);
            }
            const config = {
                type: 'line',
                data: data,
                options: {}
            };
            this.myChart= new Chart(myChartRef, config as any);
        }
    
    componentDidMount(): void {       
        this.draw();
        this.mounted = true;
    }

    render() {              
        if (this.mounted) {
            this.draw();
        }
        return (
            <React.Fragment>
                <div className="row">
                    <div className="col-sm-4">
                    </div>
                    <div className="col-sm-4">
                        <h4>Symbold Id:</h4>
                    </div>
                    <div className="col-sm-4">
                    </div>
                </div>
                <div className="row">
                    <canvas id="chart1" ref={this.chartRef} />
                </div>
            </ React.Fragment>
        );        
    }
}