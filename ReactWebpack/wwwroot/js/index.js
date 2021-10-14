import React from 'react';
import ReactDOM from 'react-dom';
//function RunList(myList) {
//    ReactDOM.render(e(List), app1);
//}
//window.RunList = RunList;
//function MyAlert(name) {
//    alert("Calling MyAlert again" + name);
//}
//window.MyAlert = MyAlert; 
var e = React.createElement;
var app1 = document.getElementById("app1");
//ReactDOM.render(e(List), app1);  
//ReactDOM.render(<List />, app1);   
var domContainer = document.querySelector('#app2');
//ReactDOM.render(<LikeButton />, domContainer);
var app3 = document.getElementById('app3');
ReactDOM.render(React.createElement("div", null,
    " ",
    React.createElement("p", null, "Hello, world! 12"),
    " "), app3);
//# sourceMappingURL=index.js.map