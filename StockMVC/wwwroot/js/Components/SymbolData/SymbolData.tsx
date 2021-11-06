import axios from "axios";
import PointData from "../.././Models/PointData";

interface type {
    data: [PointData];
}

export default class SymbolData {
    PointDataArray: PointData[];
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

    public async GetRatioTradeData(symbolId1: number, symbolId2: number): Promise<PointData[]> {
        this.PointDataArray = [];
        try {
            const response = await axios.get(`/api/symbol/GetRatioTradeData?symbolId1=${symbolId1}&symbolId2=${symbolId2}`);
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
