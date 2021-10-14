import React from 'react';
import ReactDOM from 'react-dom';
import List from "./List";
import LikeButton from "./LikeButton";

const e = React.createElement;

var app1 = document.getElementById("app1");
//ReactDOM.render(e(List), app1);  

function RunList(myList) {
    ReactDOM.render(e(List), app1);
}
window.RunList = RunList;

function MyAlert(name) {
    alert("Calling MyAlert again"+ name);  
}
window.MyAlert = MyAlert;


const domContainer = document.querySelector('#app2');
ReactDOM.render(e(LikeButton), domContainer);

var app3 = document.getElementById('app3'); 

ReactDOM.render(<div> <p>Hello, world! again1234568</p> </div>, app3);

//module.hot.accept();
//test