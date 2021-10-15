import React from "react";
import ReactDOM from "react-dom";
import List from "./List.jsx"; 
import LikeButton from "./LikeButton";
import Button from "./Components/Button/index.jsx"

const globalScope = (window /* browser */ || global /* node */) ;
export function MyAlert(name) {
    alert("Calling MyAlert again" + name);
}
globalScope.MyAlert = MyAlert;


const e = React.createElement;

var app1 = document.getElementById("app1");
ReactDOM.render(<List />, app1);   

const domContainer = document.querySelector("#app2");
ReactDOM.render(<LikeButton />, domContainer);

var app3 = document.getElementById("app3");   
ReactDOM.render(<div> <p>Hello, world! 1234</p> </div>, app3); 

var app4 = document.getElementById("app4");
ReactDOM.render(<Button />, app4); 
 


