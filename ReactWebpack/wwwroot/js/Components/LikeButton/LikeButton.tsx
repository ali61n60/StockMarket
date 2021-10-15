import * as React from "react";

interface MyProps { }

interface MyState {
    liked: boolean;
}

export default class LikeButton extends React.Component<MyProps,MyState > {
    constructor(props:MyProps) {
        super(props);
        this.state = { liked :false };
    }
    
    render() {
        if (this.state.liked) {
            return 'You liked this.';
        }

        return React.createElement(
            'button', { onClick: () => this.setState({ liked: true }) }, 'Like');
    } 
}

