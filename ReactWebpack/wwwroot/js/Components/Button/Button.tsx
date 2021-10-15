import * as React from "react";


interface Props {
    type:"primary"|"default";
}

export default class Button extends React.Component<Props,{}> {
    constructor(props: Props) {
        super(props);
        
    }

    render() {
        const className = this.props.type === "primary" ? "btn-primary" : "btn-danger";
        return (
                
            <div>
                <button className={className} >Button</button>
                <h1>bu</h1>
            </div> 
        );
    }
}


