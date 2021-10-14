"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Drawer = require("./DrawLib/Drawer");
var Drawer1 = Drawer.Drawer;
var Point = Drawer.Point;
var greet_1 = require("./greet");
function showHello(divName, name) {
    var elt = document.getElementById(divName);
    elt.innerText = (0, greet_1.sayHello)(name);
}
function DrawLine(canvasId, x1, y1, x2, y2, color) {
    var drawer = new Drawer1(canvasId);
    var p1 = new Point();
    p1.x = x1;
    p1.y = y1;
    var p2 = new Point();
    p2.x = x2;
    p2.y = y2;
    drawer.DrawLine(p1, p2, color);
}
global.ShowHello = showHello;
global.DrawLine = DrawLine;
//# sourceMappingURL=main.js.map