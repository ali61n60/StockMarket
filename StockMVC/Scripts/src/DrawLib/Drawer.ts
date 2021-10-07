export  class Point {
     x: number;
     y:number;
}
export  class Drawer {
    _canvasId:string;
    constructor(canvasId: string) {
        this._canvasId = canvasId; 
    }
    DrawLine(p1: Point, p2: Point,color:string): void {

        var canvas = <HTMLCanvasElement> document.getElementById(this._canvasId) ;
         

         if (!canvas.getContext) {
             return;
         }
         const ctx = canvas.getContext('2d');

         // set line stroke and line width
         ctx.strokeStyle = color;
         ctx.lineWidth = 1;

         // draw a red line
         ctx.beginPath();
         ctx.moveTo(p1.x, p1.y);
         ctx.lineTo(p2.x, p2.y);
         ctx.stroke();
    }
}



