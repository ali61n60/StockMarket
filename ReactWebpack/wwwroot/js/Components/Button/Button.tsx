import * as React from "react";


interface Props {
    type:"primary"|"default";
}
interface State {
    changed: boolean;
}

export default class Button extends React.Component<Props, State> {
    i: number=19;
    constructor(props: Props) {
        super(props);
        this.state = { changed: false };
        
    }
    

    render() {
        const className = this.props.type === "primary" ? "btn btn-block btn-primary" : "btn btn-block btn-danger";
        return (                
            <div>
                <p className="text-center">number is: {this.i}</p>
                <button className={className} onClick={this.handleClick}  >Button</button>                
            </div> 
        );
    }

    handleClick = () => {
        this.i++;
        this.setState({ changed: true });        
    }
}


