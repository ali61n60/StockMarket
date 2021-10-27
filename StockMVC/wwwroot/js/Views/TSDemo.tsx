import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import List from "../Components/List/List";
import Button from "../Components/Button/Button";
import ChartDraw from "../Components/ChartDraw/ChartDraw";
import Symbol from "../Models/Symbol";
import SymbolGroup from "../Models/SymbolGroup";
import SymbolSelector from "../Components/SymbolSelector/SymbolSelector";
import Game from ".././Components/TicTakToe/TikTakToe";
import DigitalClock from "../Components/DigitalClock/DigitalClock";
import ToggleButton from "../Components/LikeButton/ToggleButton"


$(document).ready(() => {
  
    ReactDOM.render(<React.Fragment>
        <div className="row">
            <div className="col-sm-4" id="SymbolSelector"></div>
            <div className="col-sm-4" id="app2">
                <Game />
            </div>
           
            <div className="col-sm-4" id="ToggleButton">
                <ToggleButton />
            </div>
        </div>
        <div className="row">
            <div className="col-sm-4" id="Button"></div>
            <div className="col-sm-4" id="List"></div>
            <div className="col-sm-4" id="DigitalClock">
                <DigitalClock />
                <br />
                <DigitalClock />
                <br/>
                <DigitalClock />
            </div>
        </div>
        <div className="row">
            <div className="col-sm-4" id="app7"></div>
            <div className="col-sm-4" id="app8"></div>
            <div className="col-sm-4" id="app9"></div>
        </div>
        <div className="row">
            <div className="col-sm-12" id="ChartDraw"></div>
        </div>
    </React.Fragment>,
        $("#main")[0]); 
    RenderSymbolSelector();
    RenderList();
    RenderButton();
    RenderChartDraw(1);

    function SelectedSymbolChanged(newSymbolId: number) {
        RenderChartDraw(newSymbolId);
    }

    function RenderSymbolSelector() {
        let allSymbolsJsonString = $("#AllSymbols").val().toString();
        let symbolArray: [Symbol] = $.parseJSON(allSymbolsJsonString);
        let allSymbolGroupsJsonString = $("#AllSymbolGroups").val().toString();
        let symbolGroupArray: [SymbolGroup] = $.parseJSON(allSymbolGroupsJsonString);
        ReactDOM.render(
            <SymbolSelector SymbolArray={symbolArray}
                SymbolGroupArray={symbolGroupArray}
                OwnerName="Ali"
                CustomCallBack={SelectedSymbolChanged}
                Id="Selector1" />,
            $("#SymbolSelector")[0]);
    }

    function RenderList() {
        let listData = [];
        ReactDOM.render(<List listData={listData} />, $("#List")[0]);
    }

    function RenderButton() {
        ReactDOM.render(
            <div>
                <Button type="primary">test1</Button>
                <Button type="default">test2</Button>
            </div>
            , $("#Button")[0]);
    }

    function RenderChartDraw(symbolId: number) {
        ReactDOM.render(<ChartDraw SymbolId={symbolId} />, $("#ChartDraw")[0]);
    }
});



