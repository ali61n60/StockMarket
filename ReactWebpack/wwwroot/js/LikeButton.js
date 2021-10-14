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
import React from "react";
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
        return React.createElement('button', { onClick: function () { return _this.setState({ liked: true }); } }, 'Like');
    };
    return LikeButton;
}(React.Component));
export default LikeButton;
//# sourceMappingURL=LikeButton.js.map