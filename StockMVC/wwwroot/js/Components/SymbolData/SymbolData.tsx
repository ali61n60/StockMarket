import axios from "axios";
import PointData from "../.././Models/PointData";

interface type {
    data: [PointData];
}

export default class SymbolData {
    PointDataArray: PointData[] ;
    public async GetSymbolTradeData(symbolId: number): Promise<PointData[]> {
        //Get symbol data from server based on symbolId   http://localhost:2333
        this.PointDataArray = [];
        try {
            const response = await axios.get(`/api/symbol/GetSymbolTradeData?symbolId=${symbolId}`);
            console.log(response);
            for (let i = 0; i < ((response.data) as []).length; i++) {
                this.PointDataArray.push(response.data[i]);
            }
        } catch (error) {
            console.error(error);
        }

        return this.PointDataArray;
     }
}
