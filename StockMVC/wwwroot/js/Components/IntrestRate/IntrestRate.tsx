import * as React from "react";
import { Response } from "../../Models/Response/Response";
import { ResponseStatus } from "../../Models/Response/ResponseStatus";
import LoanCalculotor from "../../Services/LoanCalculator";

interface Props { }

interface State {

}

export default class IntrestRate extends React.Component<Props, State> {
    constructor(props) {
        super(props);
    }

    TotalLoan: number = 10;
    TotalLoanRef = React.createRef() as any;

    NumberOfInstallments: number = 1;
    NumberOfInstallmentsRef = React.createRef() as any;

    PayPerMonth: number=1;
    PayPerMonthRef = React.createRef() as any;

    IntrestRate: number;
    IntrestRateRef = React.createRef() as any;
    
    LabelMessageRef = React.createRef() as any;
    showMessageToUser(message: string) {
        this.LabelMessageRef.current.innerText = message;
    }
    handleIntrestRateChange = () => {
        console.log("Intrest Rate Input element changed");
    }

    handlePayPerMonthChange = () => {

        let responseUserInput = this.UpdateUserInput();//check user input text is number
                if (responseUserInput.Status === ResponseStatus.Error) {
                    this.showMessageToUser(responseUserInput.Message); //show error message to user
            return;
        }

        let responseCalculteRate = new LoanCalculotor().CalculateRate(this.TotalLoan, this.PayPerMonth, this.NumberOfInstallments);
        if (responseCalculteRate.Status === ResponseStatus.Error) {
            this.showMessageToUser(responseCalculteRate.Message); //show error message to user
            return;
        }
        //update intrest rate fied
        this.IntrestRateRef.current.value = responseCalculteRate.Data;
    }

    UpdateUserInput(): Response<void> {
        let response = new Response<void>();
        //Todo check for input format and characters
        this.TotalLoan = parseFloat(this.TotalLoanRef.current.value);
        this.NumberOfInstallments = parseFloat(this.NumberOfInstallmentsRef.current.value);
        this.PayPerMonth = parseFloat(this.PayPerMonthRef.current.value);
        this.IntrestRate = parseFloat(this.IntrestRateRef.current.value);
        response.Status = ResponseStatus.Ok; 

        return response;
    }

    labelStyle = {
        visibility: "visible",
    } as const;

    render() {       
        return (
            <React.Fragment>
                <fieldset>
                    <legend>مبلغ وام</legend>
                    <input ref={this.TotalLoanRef} />
                </fieldset>
                 <fieldset>
                    <legend>تعداد اقساط</legend>
                    <input ref={this.NumberOfInstallmentsRef}/>
                </fieldset>
                <fieldset>
                    <legend>قسط هر ماه</legend>
                    <input ref={this.PayPerMonthRef} onChange={this.handlePayPerMonthChange} />
                </fieldset>
                <fieldset>
                    <legend>نرخ سود</legend>
                    <input ref={this.IntrestRateRef} onChange={this.handleIntrestRateChange} />
                </fieldset>
                <label ref={this.LabelMessageRef} style={this.labelStyle} >h</label>
            </React.Fragment>
        );
    }
}

