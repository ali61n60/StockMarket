import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import ChartDraw from "../Components/ChartDraw/ChartDraw";
import Symbol from "../Models/Symbol";
import SymbolGroup from "../Models/SymbolGroup";
import SymbolSelector from "../Components/SymbolSelector/SymbolSelector";
import DigitalClock from "../Components/DigitalClock/DigitalClock";

$(document).ready(() => {
  
    ReactDOM.render(<React.Fragment>
        <div className="row">
            <div className="col-sm-4" >
                <div className="row" id="DigitalClock"><DigitalClock /></div>
                <br/>
                 <div className="row" id="SymbolSelector">
                </div>
            </div>
            <div className="col-sm-4" id="ToggleButton"></div>
            <div className="col-sm-4" id="app1"></div>
        </div>
        <div className="row">
            <div className="col-sm-4" id="Button"></div>
            <div className="col-sm-4" id="List"></div>
            <div className="col-sm-4" id="Game"></div>           
        </div>
        <div className="row">
            <div className="col-sm-4" id="BoilingVerdict"></div>
            <div className="col-sm-4" id="RandomDrawer"></div>
            <div className="col-sm-4" id="app9"></div>
        </div>
        <div className="row">
            <div className="col-sm-12" id="ChartDraw">
                <ChartDraw SymbolId={1} /></div>
        </div>
    </React.Fragment>,
        $("#main")[0]); 
    RenderSymbolSelector();   
    RenderChartDraw(1);

    function SelectedSymbolChanged(newSymbolId: number) {
        RenderChartDraw(newSymbolId);
    }

    function RenderSymbolSelector() {
        const allSymbolsJsonString = $("#AllSymbols").val().toString();
        const symbolArray: [Symbol] = $.parseJSON(allSymbolsJsonString);
        const allSymbolGroupsJsonString = $("#AllSymbolGroups").val().toString();
        const symbolGroupArray: [SymbolGroup] = $.parseJSON(allSymbolGroupsJsonString);
        ReactDOM.render(
            <div className="row">
                <div className="col-sm-6">
                    <SymbolSelector SymbolArray={symbolArray}
                        SymbolGroupArray={symbolGroupArray}
                        CustomCallBack={SelectedSymbolChanged}
                        Id="Selector1" />
                </div>
                <div className="col-sm-6">
                    <SymbolSelector SymbolArray={symbolArray}
                        SymbolGroupArray={symbolGroupArray}
                        CustomCallBack={SelectedSymbolChanged}
                        Id="Selector2" />
                </div>                   
            </div>,
            $("#SymbolSelector")[0]);
    }   

    function RenderChartDraw(symbolId: number) {
        ReactDOM.render(<ChartDraw SymbolId={symbolId} />, $("#ChartDraw")[0]);
    }
});



