import * as React from "react";

interface Props {
    celsius: number;
}
interface State {
    
}

export default class BoilingVerdict extends React.Component<Props, State> {
    
    constructor(props: Props) {
        super(props);
    }
    
    render() {
        if (this.props.celsius >= 100) {
            return <p>The water would boil.</p>;
        }
        return <p>The water would not boil.</p>;
    }    
}




