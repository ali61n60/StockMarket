import  React from 'react';
import  ReactDOM from 'react-dom';
import  List from "./List"; 
import LikeButton from "./LikeButton";

const globalScope = (window /* browser */ || global /* node */) as any;

function RunList(myList) {
    ReactDOM.render(e(List), app1);
}


export function MyAlert(name) {
    alert("Calling MyAlert again" + name);
}


globalScope.MyAlert = MyAlert;
globalScope.RunList = RunList;

const e = React.createElement;
var app1 = document.getElementById("app1");
//ReactDOM.render(e(List), app1);  
//ReactDOM.render(<List />, app1);   

const domContainer = document.querySelector('#app2');
ReactDOM.render(<LikeButton />, domContainer);

var app3 = document.getElementById('app3');   
ReactDOM.render(<div> <p>Hello, world! 1234</p> </div>, app3); 



