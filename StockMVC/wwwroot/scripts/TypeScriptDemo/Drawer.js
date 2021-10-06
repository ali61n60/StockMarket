var Point = /** @class */ (function () {
    function Point() {
    }
    return Point;
}());
var Drawer = /** @class */ (function () {
    function Drawer(canvasId) {
        this._canvasId = canvasId;
    }
    Drawer.prototype.DrawLine = function (p1, p2) {
        var canvas = document.getElementById(this._canvasId);
        if (!canvas.getContext) {
            return;
        }
        var ctx = canvas.getContext('2d');
        // set line stroke and line width
        ctx.strokeStyle = 'red';
        ctx.lineWidth = 5;
        // draw a red line
        ctx.beginPath();
        ctx.moveTo(p1.x, p1.y);
        ctx.lineTo(p2.x, p2.y);
        ctx.stroke();
    };
    return Drawer;
}());
var drawer = new Drawer("chart1");
var p1 = new Point();
p1.x = 10;
p1.y = 10;
var p2 = new Point();
p2.x = 20;
p2.y = 20;
drawer.DrawLine(p1, p2);
//# sourceMappingURL=Drawer.js.map