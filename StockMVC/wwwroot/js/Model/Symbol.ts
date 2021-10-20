export class Symbol {
    Id: number;
    SymbolLatin: string;
    NameLatin: string;
    NamePersian: string;
    SymbolPersian: string;
    GroupId: number;
    SymbolGroup: SymbolGroup;
    LiveDataUrl: LiveDataUrl;
    SoldStockExchages: ICollection<StockExchange>;
    BoughtStockExchages: ICollection<StockExchange>;
    Dividends: ICollection<Dividend>;
    StockTradings: ICollection<StockTrading>;
    StockListStockInfo: ICollection<CustomGroupMember>;
}

interface SymbolGroup { }
interface LiveDataUrl { }
interface ICollection<StockExchange> { }
interface StockExchange { }
interface StockTrading { }
interface Dividend { }
interface CustomGroupMember { }