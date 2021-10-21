import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery"; 
import List from "./Components/List/List";
import LikeButton from "./Components/LikeButton/LikeButton";
import Button from "./Components/Button/Button";
import ChartDraw from "./Components/ChartDraw/ChartDraw";
import Symbol from "./Models/Symbol";
import SymbolGroup from "./Models/SymbolGroup";
import SymbolSelector from "./Components/SymbolSelector/SymbolSelector";

$(document).ready( ()=> {
    let listData = [];
    
    let allSymbolsJsonString = $("#AllSymbols").val().toString();
    let symbolArray: [Symbol] = $.parseJSON(allSymbolsJsonString);
    
    let allSymbolGroupsJsonString = $("#AllSymbolGroups").val().toString();
    let symbolGroupArray: [SymbolGroup] = $.parseJSON(allSymbolGroupsJsonString);

    ReactDOM.render(
        <SymbolSelector SymbolArray={symbolArray}
            SymbolGroupArray={symbolGroupArray}
            OwnerName="Ali"
            CustomCallBack={CallBack}
            Id="Selector1" />,
        $("#app1")[0]);

    ReactDOM.render(<LikeButton />, $("#app2")[0]); 

    ReactDOM.render(<div> <p>Hello, world! 1234</p> </div>, $("#app3")[0]);

    ReactDOM.render(
        <div>
            <Button type="primary">test1</Button>
            <Button type="default">test2</Button>  
        </div>
        , $("#app4")[0]);

    ReactDOM.render(<List listData={listData} />, $("#app5")[0]);

    ReactDOM.render(<ChartDraw ownerName="Ali" CustomCallBack={CallBack}  />, $("#app10")[0]);

    function CallBack(message: string) {
        listData.unshift(message)
        ReactDOM.render(<List listData={listData} />, $("#app5")[0]);
    }

});



