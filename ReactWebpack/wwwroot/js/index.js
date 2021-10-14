import React from 'react';
import ReactDOM from 'react-dom';
import List from "./List";
import LikeButton from "./LikeButton";
var globalScope = (window /* browser */ || global /* node */);
function RunList(myList) {
    ReactDOM.render(e(List), app1);
}
export function MyAlert(name) {
    alert("Calling MyAlert again" + name);
}
globalScope.MyAlert = MyAlert;
globalScope.RunList = RunList;
var e = React.createElement;
var app1 = document.getElementById("app1");
//ReactDOM.render(e(List), app1);  
//ReactDOM.render(<List />, app1);   
var domContainer = document.querySelector('#app2');
ReactDOM.render(React.createElement(LikeButton, null), domContainer);
var app3 = document.getElementById('app3');
ReactDOM.render(React.createElement("div", null,
    " ",
    React.createElement("p", null, "Hello, world! 123"),
    " "), app3);
//# sourceMappingURL=index.js.map