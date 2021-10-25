﻿import * as React from "react";


interface IGameProps {
    
}

interface IGameStates {
    history: {squares: string[]}[];
    xIsNext: boolean;
    stepNumber: number;
}
export default class Game extends React.Component<IGameProps,IGameStates> {
    constructor(props) {
        super(props);
        this.state = {
            history: [{
                squares: Array(9).fill(null),
            }],
            stepNumber: 0,
            xIsNext: true,
        };
    }
    render() {
        const history = this.state.history;
        const current = history[history.length - 1];
        const winner = calculateWinner(current.squares);
        const moves = history.map((step, move) => {
            const desc = move ?
                'Go to move #' + move :
                'Go to game start';
            return (
                 <li key={move}>
                     <button onClick={() => this.jumpTo(move)}>{desc}</button> 
                 </li>
                
            );
        });
        let status;
        if (winner) {
            status = 'Winner: ' + winner;
        } else {
            status = 'Next player: ' + (this.state.xIsNext ? 'X' : 'O');
        }
                
        return (
            <div className="game">
                <div className="game-board">
                    <Board squares={current.squares} xIsNext={true} onClick={(i) => this.handleClick(i)} />
                </div>
                <div className="game-info">
                    <div>{ status }</div>
                    <ol>{moves}</ol>
                </div>
            </div>
        );
    }

    handleClick(i: number) {
        const history = this.state.history.slice(0, this.state.stepNumber + 1);
        const current = history[this.state.stepNumber];
        const squares = current.squares.slice();
        if (calculateWinner(squares) || squares[i]) {
            return;
        }
        squares[i] = this.state.xIsNext ? 'X' : 'O';
        this.setState({
            history: history.concat([{
                squares: squares,
            }]),
            stepNumber: history.length,
            xIsNext: !this.state.xIsNext,
        });
    }

    jumpTo(step) {
        this.setState({
            stepNumber: step,
            xIsNext: (step % 2) === 0,
        });
    }
}

interface ISquarProp {
    value: string;
    onClick;
}
interface  ISquareState {
    value: string;
}
class Square extends React.Component<ISquarProp, ISquareState> {
    
    render() {
        return (
            <button className="square" onClick={this.buttonClick}>
                {this.props.value}
            </button>
        );
    }

    buttonClick=() => {
        this.props.onClick();
    }
}

interface IBoardProp {
     squares: Array<string>;
    xIsNext: boolean;
    onClick;
}

interface IBoardState {
    squares: Array<string>;
    xIsNext:boolean;
}
class Board extends React.Component<IBoardProp,IBoardState> {
    
    handleClick = (i: number) => {
        const squares = this.state.squares.slice();
        if (calculateWinner(squares) || squares[i]) {
            return;
        }
        squares[i] = this.state.xIsNext ? "X" : "O";
    }
    renderSquare(i: number) {
        return <Square value={this.props.squares[i]}
            onClick={() => this.props.onClick(i)} />;
    }   

    render() {       
        return (
            <div>
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
function calculateWinner(squares) {
    const lines = [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8],
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8],
        [0, 4, 8],
        [2, 4, 6]
    ];
    for (let i = 0; i < lines.length; i++) {
        const [a, b, c] = lines[i];
        if (squares[a] && squares[a] === squares[b] && squares[a] === squares[c]) {
            return squares[a];
        }
    }
    return null;
}
