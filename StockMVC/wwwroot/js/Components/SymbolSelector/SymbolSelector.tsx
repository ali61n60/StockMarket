import * as React from "react";
import * as ReactDOM from "react-dom";
import * as $ from "jquery";
import Symbol from "../.././Models/Symbol";
import SymbolGroup from "../.././Models/SymbolGroup";


interface Props {   
    SymbolArray: [Symbol];
    SymbolGroupArray: [SymbolGroup];
    CustomCallBack(newSymbolId: number);
    Id: string;
}
interface State {
    counter: number;
    selectedSymbolId: number;
    selectedGroupId: number;
}

export default class SymbolSelector extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state = { counter: 0, selectedSymbolId: 0, selectedGroupId:1 };
    }

    render() {        
        return (
            <React.Fragment>
                <select onChange={this.onSymbolGroupChange} className="form-control" name="SymbolSelectName" id="symbolGroupSelect">
                    {((rows) => {
                        for (let i = 0; i < this.props.SymbolGroupArray.length; i++) {
                            rows.push(<option value={this.props.SymbolGroupArray[i].Id}> {this.props.SymbolGroupArray[i].Name} </option> as any);
                        }
                        return rows;
                    })([])}
                </select>
                <br/>
                <select onChange={this.onSymbolChange} className="form-control" name="SymbolSelectName" id={this.props.Id}>
                    {((rows,selectedGroup) => {
                        for (let i = 0; i < this.props.SymbolArray.length; i++) {
                            if (this.props.SymbolArray[i].GroupId == selectedGroup) {
                                rows.push(<option value={this.props.SymbolArray[i].Id}> {this.props.SymbolArray[i]
                                    .NamePersian} </option> as any);
                            }
                        }
                        return rows;
                    })([],this.state.selectedGroupId)}
                </select>
            </ React.Fragment>
        );
    }

    onSymbolChange = () => {
        this.props.CustomCallBack(Number($(`#${this.props.Id} :selected`).val()));
    }

    onSymbolGroupChange=() => {
        this.setState({
            selectedGroupId: $("#symbolGroupSelect :selected").val() as number
    });
    }
}
