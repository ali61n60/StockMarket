import * as React from "react";

interface Props {
    listData: string[];
}
interface State {
    

}
export default class List extends React.Component<Props, State> {
    render() {

        return (<ul>
            { ((rows)=> {
                for (var i = 0; i < this.props.listData.length;i++) {
                    rows.push((<li>{this.props.listData[i]}</li>) as any);
                }
                return rows;
            })([])}           
        </ul>);
    } 
}

