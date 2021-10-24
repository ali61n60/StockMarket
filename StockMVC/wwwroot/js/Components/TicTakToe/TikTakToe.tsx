import * as React from "react";

export default class Game extends React.Component {
    render() {
        return (
            <div className="game">
                <div className="game-board">
                    <Board />
                </div>
                <div className="game-info">
                    <div>{/* status */}</div>
                    <ol>{/* TODO */}</ol>
                </div>
            </div>
        );
    }
}

interface ISquarProp {
    value:number;
}

interface  ISquareState {
    value:string;
}

class Square extends React.Component<ISquarProp, ISquareState> {
    constructor(props:ISquarProp) {
        super(props);
        this.state = { value: "" };
    }

    render() {
        return (
            <button className="square" onClick={this.buttonClick}>
                {this.state.value}
            </button>
        );
    }

    buttonClick=() => {
         this.setState({value:"X"});
    }
}


interface IBoardProp {
    
}

interface IBoardState {
    squares: Array<string>;
}
class Board extends React.Component<IBoardProp,IBoardState> {
    constructor(props: IBoardProp) {
        super(props);
        this.state = { squares: Array(9).fill(null) };
       
    }

    renderSquare(i) {
        return <Square value={i} />;
    }

    render() {
        const status = 'Next player: X';

        return (
            <div>
                <div className="status">{status}</div>
                <div className="board-row">
                    {this.renderSquare(0)}
                    {this.renderSquare(1)}
                    {this.renderSquare(2)}
                </div>
                <div className="board-row">
                    {this.renderSquare(3)}
                    {this.renderSquare(4)}
                    {this.renderSquare(5)}
                </div>
                <div className="board-row">
                    {this.renderSquare(6)}
                    {this.renderSquare(7)}
                    {this.renderSquare(8)}
                </div>
            </div>
        );
    }
}


// ========================================

