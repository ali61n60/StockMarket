import * as React from "react";
import * as ReactDOM from "react-dom";
import List from "./Components/List/List";
import LikeButton from "./Components/LikeButton/LikeButton";
import Button from "./Components/Button/Button";
import CounterManagement from "./Components/CounterManagement/CounterManagement";



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
        <Button type="primary">test1</Button>
        <Button type="default">test2</Button> 
    </div>
    , app4);

var app5 = document.getElementById("app5");
ReactDOM.render(<CounterManagement ownerName="Ali Nejati" CustomCallBack={CallBack} />, app5);

function CallBack(num:number) {
    alert(`CallBack with number: ${num}`);
}
