(function(){function r(e,n,t){function o(i,f){if(!n[i]){if(!e[i]){var c="function"==typeof require&&require;if(!f&&c)return c(i,!0);if(u)return u(i,!0);var a=new Error("Cannot find module '"+i+"'");throw a.code="MODULE_NOT_FOUND",a}var p=n[i]={exports:{}};e[i][0].call(p.exports,function(r){var n=e[i][1][r];return o(n||r)},p,p.exports,r,e,n,t)}return n[i].exports}for(var u="function"==typeof require&&require,i=0;i<t.length;i++)o(t[i]);return o}return r})()({1:[function(require,module,exports){
"use strict";
exports.__esModule = true;
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
},{}],2:[function(require,module,exports){
"use strict";
exports.__esModule = true;
exports.sayHello = void 0;
function sayHello(name) {
    return "Hello done from " + name;
}
exports.sayHello = sayHello;
},{}],3:[function(require,module,exports){
(function (global){(function (){
"use strict";
exports.__esModule = true;
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
}).call(this)}).call(this,typeof global !== "undefined" ? global : typeof self !== "undefined" ? self : typeof window !== "undefined" ? window : {})

},{"./DrawLib/Drawer":1,"./greet":2}]},{},[3])
//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIm5vZGVfbW9kdWxlcy9icm93c2VyLXBhY2svX3ByZWx1ZGUuanMiLCJTY3JpcHRzL3NyYy9EcmF3TGliL0RyYXdlci50cyIsIlNjcmlwdHMvc3JjL2dyZWV0LnRzIiwiU2NyaXB0cy9zcmMvbWFpbi50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTs7OztBQ0FBO0lBQUE7SUFHQSxDQUFDO0lBQUQsWUFBQztBQUFELENBSEEsQUFHQyxJQUFBO0FBSGEsc0JBQUs7QUFJbkI7SUFFSSxnQkFBWSxRQUFnQjtRQUN4QixJQUFJLENBQUMsU0FBUyxHQUFHLFFBQVEsQ0FBQztJQUM5QixDQUFDO0lBQ0QseUJBQVEsR0FBUixVQUFTLEVBQVMsRUFBRSxFQUFTLEVBQUMsS0FBWTtRQUV0QyxJQUFJLE1BQU0sR0FBdUIsUUFBUSxDQUFDLGNBQWMsQ0FBQyxJQUFJLENBQUMsU0FBUyxDQUFDLENBQUU7UUFHekUsSUFBSSxDQUFDLE1BQU0sQ0FBQyxVQUFVLEVBQUU7WUFDcEIsT0FBTztTQUNWO1FBQ0QsSUFBTSxHQUFHLEdBQUcsTUFBTSxDQUFDLFVBQVUsQ0FBQyxJQUFJLENBQUMsQ0FBQztRQUVwQyxpQ0FBaUM7UUFDakMsR0FBRyxDQUFDLFdBQVcsR0FBRyxLQUFLLENBQUM7UUFDeEIsR0FBRyxDQUFDLFNBQVMsR0FBRyxDQUFDLENBQUM7UUFFbEIsa0JBQWtCO1FBQ2xCLEdBQUcsQ0FBQyxTQUFTLEVBQUUsQ0FBQztRQUNoQixHQUFHLENBQUMsTUFBTSxDQUFDLEVBQUUsQ0FBQyxDQUFDLEVBQUUsRUFBRSxDQUFDLENBQUMsQ0FBQyxDQUFDO1FBQ3ZCLEdBQUcsQ0FBQyxNQUFNLENBQUMsRUFBRSxDQUFDLENBQUMsRUFBRSxFQUFFLENBQUMsQ0FBQyxDQUFDLENBQUM7UUFDdkIsR0FBRyxDQUFDLE1BQU0sRUFBRSxDQUFDO0lBQ2xCLENBQUM7SUFDTCxhQUFDO0FBQUQsQ0F6QkEsQUF5QkMsSUFBQTtBQXpCYSx3QkFBTTs7Ozs7QUNKbkIsU0FBZ0IsUUFBUSxDQUFDLElBQVk7SUFDbEMsT0FBTyxxQkFBbUIsSUFBTSxDQUFDO0FBQ3JDLENBQUM7QUFGQSw0QkFFQTs7Ozs7QUNGQSx5Q0FBMkM7QUFDNUMsSUFBTyxPQUFPLEdBQUcsTUFBTSxDQUFDLE1BQU0sQ0FBQztBQUMvQixJQUFPLEtBQUssR0FBRyxNQUFNLENBQUMsS0FBSyxDQUFDO0FBQzVCLGlDQUFtQztBQUVuQyxTQUFTLFNBQVMsQ0FBQyxPQUFlLEVBQUUsSUFBWTtJQUM1QyxJQUFNLEdBQUcsR0FBRyxRQUFRLENBQUMsY0FBYyxDQUFDLE9BQU8sQ0FBQyxDQUFDO0lBQzdDLEdBQUcsQ0FBQyxTQUFTLEdBQUcsSUFBQSxnQkFBUSxFQUFDLElBQUksQ0FBQyxDQUFDO0FBQ25DLENBQUM7QUFLRCxTQUFTLFFBQVEsQ0FBQyxRQUFlLEVBQUMsRUFBUyxFQUFDLEVBQVMsRUFBQyxFQUFTLEVBQUMsRUFBUyxFQUFDLEtBQVk7SUFDbEYsSUFBSSxNQUFNLEdBQUcsSUFBSSxPQUFPLENBQUMsUUFBUSxDQUFDLENBQUM7SUFDbkMsSUFBSSxFQUFFLEdBQUcsSUFBSSxLQUFLLEVBQUUsQ0FBQztJQUNyQixFQUFFLENBQUMsQ0FBQyxHQUFHLEVBQUUsQ0FBQztJQUNWLEVBQUUsQ0FBQyxDQUFDLEdBQUcsRUFBRSxDQUFDO0lBQ1YsSUFBSSxFQUFFLEdBQUcsSUFBSSxLQUFLLEVBQUUsQ0FBQztJQUNyQixFQUFFLENBQUMsQ0FBQyxHQUFFLEVBQUUsQ0FBQztJQUNULEVBQUUsQ0FBQyxDQUFDLEdBQUcsRUFBRSxDQUFDO0lBQ1YsTUFBTSxDQUFDLFFBQVEsQ0FBQyxFQUFFLEVBQUUsRUFBRSxFQUFDLEtBQUssQ0FBQyxDQUFDO0FBQ2xDLENBQUM7QUFFRCxNQUFNLENBQUMsU0FBUyxHQUFHLFNBQVMsQ0FBQztBQUM3QixNQUFNLENBQUMsUUFBUSxHQUFHLFFBQVEsQ0FBQyIsImZpbGUiOiJnZW5lcmF0ZWQuanMiLCJzb3VyY2VSb290IjoiIiwic291cmNlc0NvbnRlbnQiOlsiKGZ1bmN0aW9uKCl7ZnVuY3Rpb24gcihlLG4sdCl7ZnVuY3Rpb24gbyhpLGYpe2lmKCFuW2ldKXtpZighZVtpXSl7dmFyIGM9XCJmdW5jdGlvblwiPT10eXBlb2YgcmVxdWlyZSYmcmVxdWlyZTtpZighZiYmYylyZXR1cm4gYyhpLCEwKTtpZih1KXJldHVybiB1KGksITApO3ZhciBhPW5ldyBFcnJvcihcIkNhbm5vdCBmaW5kIG1vZHVsZSAnXCIraStcIidcIik7dGhyb3cgYS5jb2RlPVwiTU9EVUxFX05PVF9GT1VORFwiLGF9dmFyIHA9bltpXT17ZXhwb3J0czp7fX07ZVtpXVswXS5jYWxsKHAuZXhwb3J0cyxmdW5jdGlvbihyKXt2YXIgbj1lW2ldWzFdW3JdO3JldHVybiBvKG58fHIpfSxwLHAuZXhwb3J0cyxyLGUsbix0KX1yZXR1cm4gbltpXS5leHBvcnRzfWZvcih2YXIgdT1cImZ1bmN0aW9uXCI9PXR5cGVvZiByZXF1aXJlJiZyZXF1aXJlLGk9MDtpPHQubGVuZ3RoO2krKylvKHRbaV0pO3JldHVybiBvfXJldHVybiByfSkoKSIsImV4cG9ydCAgY2xhc3MgUG9pbnQge1xuICAgICB4OiBudW1iZXI7XG4gICAgIHk6bnVtYmVyO1xufVxuZXhwb3J0ICBjbGFzcyBEcmF3ZXIge1xuICAgIF9jYW52YXNJZDpzdHJpbmc7XG4gICAgY29uc3RydWN0b3IoY2FudmFzSWQ6IHN0cmluZykge1xuICAgICAgICB0aGlzLl9jYW52YXNJZCA9IGNhbnZhc0lkOyBcbiAgICB9XG4gICAgRHJhd0xpbmUocDE6IFBvaW50LCBwMjogUG9pbnQsY29sb3I6c3RyaW5nKTogdm9pZCB7XG5cbiAgICAgICAgdmFyIGNhbnZhcyA9IDxIVE1MQ2FudmFzRWxlbWVudD4gZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQodGhpcy5fY2FudmFzSWQpIDtcbiAgICAgICAgIFxuXG4gICAgICAgICBpZiAoIWNhbnZhcy5nZXRDb250ZXh0KSB7XG4gICAgICAgICAgICAgcmV0dXJuO1xuICAgICAgICAgfVxuICAgICAgICAgY29uc3QgY3R4ID0gY2FudmFzLmdldENvbnRleHQoJzJkJyk7XG5cbiAgICAgICAgIC8vIHNldCBsaW5lIHN0cm9rZSBhbmQgbGluZSB3aWR0aFxuICAgICAgICAgY3R4LnN0cm9rZVN0eWxlID0gY29sb3I7XG4gICAgICAgICBjdHgubGluZVdpZHRoID0gMTtcblxuICAgICAgICAgLy8gZHJhdyBhIHJlZCBsaW5lXG4gICAgICAgICBjdHguYmVnaW5QYXRoKCk7XG4gICAgICAgICBjdHgubW92ZVRvKHAxLngsIHAxLnkpO1xuICAgICAgICAgY3R4LmxpbmVUbyhwMi54LCBwMi55KTtcbiAgICAgICAgIGN0eC5zdHJva2UoKTtcbiAgICB9XG59XG5cblxuXG4iLCLvu79leHBvcnQgZnVuY3Rpb24gc2F5SGVsbG8obmFtZTogc3RyaW5nKSB7XHJcbiAgICByZXR1cm4gYEhlbGxvIGRvbmUgZnJvbSAke25hbWV9YDtcclxufSIsIu+7v2ltcG9ydCAqIGFzIERyYXdlciBmcm9tIFwiLi9EcmF3TGliL0RyYXdlclwiO1xyXG5pbXBvcnQgRHJhd2VyMSA9IERyYXdlci5EcmF3ZXI7XHJcbmltcG9ydCBQb2ludCA9IERyYXdlci5Qb2ludDtcclxuaW1wb3J0IHsgc2F5SGVsbG8gfSBmcm9tIFwiLi9ncmVldFwiO1xyXG5cclxuZnVuY3Rpb24gc2hvd0hlbGxvKGRpdk5hbWU6IHN0cmluZywgbmFtZTogc3RyaW5nKSB7XHJcbiAgICBjb25zdCBlbHQgPSBkb2N1bWVudC5nZXRFbGVtZW50QnlJZChkaXZOYW1lKTtcclxuICAgIGVsdC5pbm5lclRleHQgPSBzYXlIZWxsbyhuYW1lKTtcclxufVxyXG5cclxuXHJcblxyXG5cclxuZnVuY3Rpb24gRHJhd0xpbmUoY2FudmFzSWQ6c3RyaW5nLHgxOm51bWJlcix5MTpudW1iZXIseDI6bnVtYmVyLHkyOm51bWJlcixjb2xvcjpzdHJpbmcpIHtcclxuICAgIGxldCBkcmF3ZXIgPSBuZXcgRHJhd2VyMShjYW52YXNJZCk7XHJcbiAgICBsZXQgcDEgPSBuZXcgUG9pbnQoKTtcclxuICAgIHAxLnggPSB4MTtcclxuICAgIHAxLnkgPSB5MTtcclxuICAgIGxldCBwMiA9IG5ldyBQb2ludCgpO1xyXG4gICAgcDIueCA9eDI7XHJcbiAgICBwMi55ID0geTI7XHJcbiAgICBkcmF3ZXIuRHJhd0xpbmUocDEsIHAyLGNvbG9yKTtcclxufVxyXG5cclxuZ2xvYmFsLlNob3dIZWxsbyA9IHNob3dIZWxsbztcclxuZ2xvYmFsLkRyYXdMaW5lID0gRHJhd0xpbmU7XHJcblxyXG5cclxuXHJcbiJdfQ==
