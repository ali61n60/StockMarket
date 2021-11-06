import axios from "axios";
import * as $ from "jquery";
import PointData from "../.././Models/PointData";




export default class SymbolData {
    public GetSymbolTradeData(symbolId: number): [PointData] {
        let PointDataArray: [PointData];
        //Get symbol data from server based on symbolId   http://localhost:2333
        axios.get(`/api/symbol/GetSymbolTradeData?symbolId=${symbolId}`).then(response => {
            PointDataArray = response.data as [PointData];
        });
        return PointDataArray;
     }
}
