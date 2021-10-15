import * as React from "react";
import * as ReactDOM from "react-dom";
import List from "./Components/List/List";
import LikeButton from "./Components/LikeButton/LikeButton";
import Button from "./Components/Button/Button";



const e = React.createElement;


var app1 = document.getElementById("app1");
ReactDOM.render(<List />, app1);

var app2 = document.getElementById("app2");
ReactDOM.render(<LikeButton />, app2);


var app3 = document.getElementById("app3");   
ReactDOM.render(<div> <p>Hello, world! 1234</p> </div>, app3); 

 
var app4 = document.getElementById("app4");
ReactDOM.render(
    <div>
    <Button type="primary" />
    <Button type="primary" />
    </div>
    , app4);


