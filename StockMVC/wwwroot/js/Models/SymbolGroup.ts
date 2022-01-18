export default class SymbolGroup{
Id: number; 
Name: string; 
Symbols: ICollection<Symbol>; 
}


interface ICollection<Symbol> { }