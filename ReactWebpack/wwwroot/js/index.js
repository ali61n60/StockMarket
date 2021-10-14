import * as React from 'react';
import * as ReactDOM from 'react-dom';
var e = React.createElement;
var app1 = document.getElementById("app1");
//ReactDOM.render(<List />, app1);
//function RunList(myList) {
//    ReactDOM.render(e(List), app1);
//}
//window.RunList = RunList;
//function MyAlert(name:string) {
//    alert("Calling MyAlert again" + name);
//}
//window.MyAlert = MyAlert;
//const domContainer = document.querySelector('#app2');
//ReactDOM.render(e(LikeButton), domContainer);
var app3 = document.getElementById('app3');
ReactDOM.render(React.createElement("div", null,
    " ",
    React.createElement("p", null, "Hello, world! again1234568"),
    " "), app3);
//# sourceMappingURL=index.js.map