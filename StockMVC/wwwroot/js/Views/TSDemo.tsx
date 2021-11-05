import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import ChartDraw from "../Components/ChartDraw/ChartDraw";
import Symbol from "../Models/Symbol";
import SymbolGroup from "../Models/SymbolGroup";
import SymbolSelector from "../Components/SymbolSelector/SymbolSelector";
import DigitalClock from "../Components/DigitalClock/DigitalClock";

$(document).ready(() => {

    ReactDOM.render(
        <React.Fragment>
            <div className="row">
                <div className="col-sm-4" >
                    <div className="row" id="DigitalClock"><DigitalClock /></div>
                    <br />
                    <div className="row" id="SymbolSelector"></div>
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
                <div className="col-sm-4" id="Chart1"><ChartDraw SymbolId={1} /></div>
                <div className="col-sm-4" id="Chart2"></div>
                <div className="col-sm-4" id="Chart3"></div>
            </div>

            <div className="jumbotron text-center">
                <p>Footer</p>
            </div>
        </React.Fragment>,
        $("#main")[0]);
    RenderSymbolSelector();
    RenderChart1(1);

    function SelectedSymbolChanged(newSymbolId: number, id: string) {
        if (id === "Selector1") {
            RenderChart1(newSymbolId);
        } else {
            RenderChart2(newSymbolId);
        }
    }

    function RenderSymbolSelector() {
        const allSymbolsJsonString = $("#AllSymbols").val().toString();
        const symbolArray: [Symbol] = $.parseJSON(allSymbolsJsonString);
        const allSymbolGroupsJsonString = $("#AllSymbolGroups").val().toString();
        const symbolGroupArray: [SymbolGroup] = $.parseJSON(allSymbolGroupsJsonString);
        ReactDOM.render(
            <React.Fragment>

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
                <br />

                <div className="col-sm-12">
                    <button className="btn btn-block btn-danger">Draw Ratio</button>
                </div>

            </React.Fragment>
            ,
            $("#SymbolSelector")[0]);
    }

    function RenderChart1(symbolId: number) {
        ReactDOM.render(<ChartDraw SymbolId={symbolId} />, $("#Chart1")[0]);
    }
    function RenderChart2(symbolId: number) {
        ReactDOM.render(<ChartDraw SymbolId={symbolId} />, $("#Chart2")[0]);
    }
});



