import * as React from "react";

interface Props { }

interface State {
    liked: boolean;
}

export default class LikeButton extends React.Component<Props,State > {
    constructor(props:Props) {
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

