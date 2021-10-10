import React from 'react';
import ReactDOM from 'react-dom';


const e = React.createElement;

class LikeButton extends React.Component {
    constructor(props) {
        super(props);
        this.state = { liked: false };
    }

    render() {
        if (this.state.liked) {
            return 'You liked this.';
        }

        return e(
            'button', { onClick: () => this.setState({ liked: true }) }, 'Like');
    }
}

const domContainer = document.querySelector('#app1');
ReactDOM.render(e(LikeButton), domContainer);

var app = document.getElementById('app2');

ReactDOM.render(<div> <p>Hello, world!</p> </div>, app);

module.hot.accept();