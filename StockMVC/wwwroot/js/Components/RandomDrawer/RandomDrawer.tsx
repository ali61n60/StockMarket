import * as React from "react";

class Point {
    x: number;
    y: number;
}

interface Props {

}
interface State {

}

export default class RandomDrawer extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

    }
    canvasStyle = {
        border: "1px solid blue"
    } as const;
    drawerId: any;
    canvasRef = React.createRef() as any;
    width = 200;
    height = 200;
    p1: Point;
    p2: Point;
    canvasW: any;
    canvasH: any;

    tick = () => {
        //create rondom point and draw it        
        this.p1.x = this.p2.x;
        this.p1.y = this.p2.y;
        this.p2.x = Math.floor(Math.random() * this.canvasW);
        this.p2.y = Math.floor(Math.random() * this.canvasH);
        this.DrawLine(this.p1, this.p2, "#" + Math.floor(Math.random() * 16777215).toString());
    }

    componentDidMount() {
        this.p1 = new Point();
        this.p2 = new Point();
        this.p2.x = 0;
        this.p2.y = 0;
        this.canvasW = this.canvasRef.current.getBoundingClientRect().width;
        this.canvasH = this.canvasRef.current.getBoundingClientRect().height;
        console.log("W=" + this.canvasW + ", H=" + this.canvasH);
        this.drawerId = setInterval(() => this.tick(), 100);
    }

    componentWillUnmount() {
        clearInterval(this.drawerId);
    }

    render() {
        return (
            <canvas id="chart1" width={this.width} height={this.height} ref={this.canvasRef} style={this.canvasStyle} />
        );
    }

    DrawLine(p1: Point, p2: Point, color: string): void {
        const ctx = this.canvasRef.current.getContext("2d");
        // set line stroke and line width
        ctx.strokeStyle = color;
        ctx.lineWidth = 1;
        ctx.beginPath();
        ctx.moveTo(p1.x, p1.y);
        ctx.lineTo(p2.x, p2.y);
        ctx.stroke();
    }
}