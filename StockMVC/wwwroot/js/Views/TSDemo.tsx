import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import ChartDraw from "../Components/ChartDraw/ChartDraw";
import Symbol from "../Models/Symbol";
import SymbolGroup from "../Models/SymbolGroup";
import SymbolSelector from "../Components/SymbolSelector/SymbolSelector";
import DigitalClock from "../Components/DigitalClock/DigitalClock";
import SymbolData from "../Components/SymbolData/SymbolData";
import PointData from "../Models/PointData";

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
                <div className="col-sm-4" id="Chart1"></div>
                <div className="col-sm-4" id="Chart2"></div>
                <div className="col-sm-4" id="Chart3"></div>
            </div>

            <div className="jumbotron text-center">
                <p>Footer</p>
            </div>
        </React.Fragment>,
        $("#main")[0]);
    RenderSymbolSelector();    

    async function SelectedSymbolChanged(newSymbolId: number, id: string) {
        //TODO get data from server and give data to ChartDraw component
        let symbolData = new SymbolData();
        let PointDataArray = await symbolData.GetSymbolTradeData(newSymbolId);
        if (id === "Selector1") {
            RenderChart1(PointDataArray);
        } else {
            RenderChart2(PointDataArray);
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

    function RenderChart1(PointDataArray: PointData[]) {
        ReactDOM.render(<ChartDraw PointDataArray={PointDataArray} />, $("#Chart1")[0]);
    }
    function RenderChart2(PointDataArray: PointData[]) {
        ReactDOM.render(<ChartDraw PointDataArray={PointDataArray} />, $("#Chart2")[0]);
    }
});



