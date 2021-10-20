import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery"; 
import List from "./Components/List/List";
import LikeButton from "./Components/LikeButton/LikeButton";
import Button from "./Components/Button/Button";
import CounterManagement from "./Components/CounterManagement/CounterManagement";
import Symbol from "./Models/Symbol";
import SymbolSelector from "./Components/SymbolSelector/SymbolSelector";

$(document).ready(function () {
    const e = React.createElement;
    let listData = ["a", "b"];
    let ModelData: string;

    let modelString = $("#Model").val().toString();
    let symbolArray: [Symbol] = $.parseJSON(modelString);
    symbolArray.forEach((S) => { listData.push(S.NamePersian.toString()); });
    

    ReactDOM.render(<SymbolSelector symbolArray={symbolArray} ownerName="Ali" CustomCallBack={CallBack} />, $("#app1")[0]);

    ReactDOM.render(<LikeButton />, $("#app2")[0]); 


    var app3 = document.getElementById("app3");
    ReactDOM.render(<div> <p>Hello, world! 1234</p> </div>, $("#app3")[0]);


    var app4 = document.getElementById("app4");
    ReactDOM.render(
        <div>
            <Button type="primary">test1</Button>
            <Button type="default">test2</Button>
        </div>
        , $("#app4")[0]);

    var app5 = document.getElementById("app5");
    ReactDOM.render(<List listData={listData} />, $("#app5")[0]);

    function CallBack(message: string) {
        listData.unshift(message)
        ReactDOM.render(<List listData={listData} />, $("#app5")[0]);
    }

});



