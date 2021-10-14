"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.HelloWorld = void 0;
var HelloWorld = /** @class */ (function () {
    function HelloWorld() {
    }
    HelloWorld.prototype.SayHi = function () {
        console.log("hello world");
    };
    return HelloWorld;
}());
exports.HelloWorld = HelloWorld;
var helloWorld = new HelloWorld();
helloWorld.SayHi();
//# sourceMappingURL=HelloWorld.js.map