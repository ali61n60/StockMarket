import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import Symbol from "../.././Models/Symbol";


interface Props {
    ownerName: string;
    symbolArray: [Symbol];
    CustomCallBack(message: string);


}
interface State {
    counter: number;
    selectedSymbolId: number;

}

export default class SymbolSelector extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state = { counter: 0, selectedSymbolId: 0 };

    }

    render() {
        const className = "btn btn-block btn-primary";
        return (
            <React.Fragment>
                <select onChange={this.handleSelectOnChange} className="form-control" name="SymbolSelectName" id="SymbolSelectId">
                    {((rows) => {
                        for (var i = 0; i < this.props.symbolArray.length; i++) {
                            rows.push(<option value={this.props.symbolArray[i].Id}>{this.props.symbolArray[i].NamePersian}  </option>);
                        }
                        return rows;
                    })([])}
                    <option value="volvo">Volvo</option>
                    <option value="saab">Saab</option>
                    <option value="opel">Opel</option>
                    <option value="audi">Audi</option>
                </select>
                <br/>
              
                <h2>Owner Name: {this.props.ownerName}</h2>
                <h3>Counter: {this.state.counter}</h3>
                <button className={className} onClick={this.handleAddClick}>Add</button>
                <button className={className} onClick={this.handleMinusClick}>Minus</button>
            </ React.Fragment>
        );
    }

    handleAddClick = () => {
        this.setState({ counter: this.state.counter + 1 });
    }

    handleMinusClick = () => {
        this.setState({ counter: this.state.counter - 1 });
        var today = new Date();
        var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
        this.props.CustomCallBack(`id changed at ${time}`);
    }

    handleSelectOnChange = () => {

        this.props.CustomCallBack(`${$("#SymbolSelectId :selected").text()} with id as  ${$("#SymbolSelectId :selected").val()}`);
    }
}
