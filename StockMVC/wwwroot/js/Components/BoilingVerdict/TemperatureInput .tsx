import * as React from "react";

const scaleNames = {
    c: 'Celsius',
    f: 'Fahrenheit'
};

interface Props {
    scale: string;
    temperature: string;
    onTemperatureChange;
}
interface State {    
}

export default class TemperatureInput extends React.Component <Props,State>{
    constructor(props) {
        super(props);              
    }

    handleChange=(e)=> {        
        this.props.onTemperatureChange(e.target.value);
    }

    render() {
        const temperature = this.props.temperature;
        const scale = this.props.scale;
        return (
            <fieldset>
                <legend>Enter temperature in {scaleNames[scale]}:</legend>
                <input value={temperature}
                    onChange={this.handleChange} />
            </fieldset>
        );
    }
}