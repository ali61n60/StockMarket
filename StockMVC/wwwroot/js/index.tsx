import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery"; 
import List from "./Components/List/List";
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

    RenderSymbolSelector();
    RenderList();
    RenderButton();
    RenderChartDraw(1);

    function SelectedSymbolChanged(newSymbolId:number) {
        RenderChartDraw(newSymbolId);
    }

    function RenderSymbolSelector() {
        ReactDOM.render(
            <SymbolSelector SymbolArray={symbolArray}
                            SymbolGroupArray={symbolGroupArray}
                            OwnerName="Ali"
                            CustomCallBack={SelectedSymbolChanged}
                            Id="Selector1" />,
            $("#app1")[0]);
    }

    function RenderList() {
        ReactDOM.render(<List listData={listData} />, $("#app5")[0]);
    }

    function RenderButton() {
        ReactDOM.render(
            <div>
                <Button type="primary">test1</Button>
                <Button type="default">test2</Button>
            </div>
            , $("#app4")[0]);
    }

    function RenderChartDraw(symbolId:number) {
        ReactDOM.render(<ChartDraw SymbolId={symbolId} />, $("#app10")[0]); 
    }

});



