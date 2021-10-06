class Point {
     x: number;
     y:number;
}
class Drawer {
    _canvasId:string;
    constructor(canvasId: string) {
        this._canvasId = canvasId;
    }
    DrawLine(p1: Point, p2: Point): void {

        var canvas = <HTMLCanvasElement> document.getElementById(this._canvasId) ;
         

         if (!canvas.getContext) {
             return;
         }
         const ctx = canvas.getContext('2d');

         // set line stroke and line width
         ctx.strokeStyle = 'red';
         ctx.lineWidth = 5;

         // draw a red line
         ctx.beginPath();
         ctx.moveTo(p1.x, p1.y);
         ctx.lineTo(p2.x, p2.y);
         ctx.stroke();
    }
}

let drawer = new Drawer("chart1");
let p1 = new Point();
p1.x = 10;
p1.y = 10;
let p2 = new Point();
p2.x = 20;
p2.y = 20;
drawer.DrawLine(p1,p2);

