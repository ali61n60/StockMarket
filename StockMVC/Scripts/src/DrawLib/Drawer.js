"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Drawer = exports.Point = void 0;
var Point = /** @class */ (function () {
    function Point() {
    }
    return Point;
}());
exports.Point = Point;
var Drawer = /** @class */ (function () {
    function Drawer(canvasId) {
        this._canvasId = canvasId;
    }
    Drawer.prototype.DrawLine = function (p1, p2, color) {
        var canvas = document.getElementById(this._canvasId);
        if (!canvas.getContext) {
            return;
        }
        var ctx = canvas.getContext('2d');
        // set line stroke and line width
        ctx.strokeStyle = color;
        ctx.lineWidth = 1;
        // draw a red line
        ctx.beginPath();
        ctx.moveTo(p1.x, p1.y);
        ctx.lineTo(p2.x, p2.y);
        ctx.stroke();
    };
    return Drawer;
}());
exports.Drawer = Drawer;
//# sourceMappingURL=Drawer.js.map