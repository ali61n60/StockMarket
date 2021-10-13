import React from 'react';
import ReactDOM from 'react-dom';
import List from "./List";
import LikeButton from "./LikeButton";

const e = React.createElement;

var app1 = document.getElementById("app1");
//ReactDOM.render(e(List), app1);  

export function RunList(myList) {
    ReactDOM.render(<List items={myList} />, app1);
}
export function MyAlert() {
    alert("Calling MyAlert");
}


const domContainer = document.querySelector('#app2');
ReactDOM.render(e(LikeButton), domContainer);

var app3 = document.getElementById('app3'); 

ReactDOM.render(<div> <p>Hello, world! again1234568</p> </div>, app3);

module.hot.accept();