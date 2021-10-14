"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var react_1 = require("react");
var LikeButton = /** @class */ (function (_super) {
    __extends(LikeButton, _super);
    function LikeButton(props) {
        var _this = _super.call(this, props) || this;
        _this.state = { liked: false };
        return _this;
    }
    LikeButton.prototype.render = function () {
        var _this = this;
        if (this.state.liked) {
            return 'You liked this.';
        }
        return react_1.default.createElement('button', { onClick: function () { return _this.setState({ liked: true }); } }, 'Like');
    };
    return LikeButton;
}(react_1.default.Component));
exports.default = LikeButton;
//# sourceMappingURL=LikeButton.js.map