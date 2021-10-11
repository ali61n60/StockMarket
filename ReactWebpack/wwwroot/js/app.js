import React from 'react';
import ReactDOM from 'react-dom';
import List from   "./List";

const e = React.createElement;

var app1 = document.getElementById("app1");
ReactDOM.render(e(List), app1);

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

const domContainer = document.querySelector('#app2');
ReactDOM.render(e(LikeButton), domContainer);

var app3 = document.getElementById('app3');

ReactDOM.render(<div> <p>Hello, world! again1234568</p> </div>, app3);

module.hot.accept();