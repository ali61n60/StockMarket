import * as React from 'react';
import  * as ReactDOM from 'react-dom';
import  * as List from "./List"; 
import * as  LikeButton from "./LikeButton";


//function RunList(myList) {
//    ReactDOM.render(e(List), app1);
//}
//window.RunList = RunList;

//function MyAlert(name) {
//    alert("Calling MyAlert again" + name);
//}
//window.MyAlert = MyAlert; 


const e = React.createElement;
var app1 = document.getElementById("app1");
//ReactDOM.render(e(List), app1);  
//ReactDOM.render(<List />, app1);   

const domContainer = document.querySelector('#app2');
//ReactDOM.render(<LikeButton />, domContainer);

var app3 = document.getElementById('app3');   
ReactDOM.render(<div> <p>Hello, world! again12345689</p> </div>, app3);



