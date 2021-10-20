import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import Symbol from "../.././Models/Symbol";
import SymbolGroup from "../.././Models/SymbolGroup";


interface Props {
    OwnerName: string;
    SymbolArray: [Symbol];
    SymbolGroupArray:[SymbolGroup];
    CustomCallBack(message: string);
    Id: string;
}
interface State {
    counter: number;
    selectedSymbolId: number;
    selectedGroupId:number;
}

export default class SymbolSelector extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state = { counter: 0, selectedSymbolId: 0, selectedGroupId:1 };
    }

    render() {
        const className = "btn btn-block btn-primary";
        return (
            <React.Fragment>
                <select onChange={this.onSymbolGroupChange} className="form-control" name="SymbolSelectName" id="symbolGroupSelect">
                    {((rows) => {
                        for (var i = 0; i < this.props.SymbolGroupArray.length; i++) {
                            rows.push(<option value={this.props.SymbolGroupArray[i].Id}> {this.props.SymbolGroupArray[i].Name} </option> as any);
                        }
                        return rows;
                    })([])}
                </select>
                <br/>
                <select onChange={this.onSymbolChange} className="form-control" name="SymbolSelectName" id={this.props.Id}>
                    {((rows,selectedGroup) => {
                        for (var i = 0; i < this.props.SymbolArray.length; i++) {
                            if (this.props.SymbolArray[i].GroupId == selectedGroup) {
                                rows.push(<option value={this.props.SymbolArray[i].Id}> {this.props.SymbolArray[i]
                                    .NamePersian} </option> as any);
                            }
                        }
                        return rows;
                    })([],this.state.selectedGroupId)}
                </select>
                <br/>
              
                <h2>Owner Name: {this.props.OwnerName}</h2>
                <button className={className} onClick={this.handleMinusClick}>Show Data</button>
            </ React.Fragment>
        );
    }

    handleMinusClick = () => {
        this.setState({ counter: this.state.counter - 1 });
        var today = new Date();
        var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
        this.props.CustomCallBack(`id changed at ${time}`);
    }

    onSymbolChange = () => {

        this.props.CustomCallBack(`${$(`#${this.props.Id} :selected`).text()} with id as  ${$(`#${this.props.Id} :selected`).val()}`);
    }

    onSymbolGroupChange=() => {
        this.setState({
            selectedGroupId: $("#symbolGroupSelect :selected").val() as number
    });
    }
}
