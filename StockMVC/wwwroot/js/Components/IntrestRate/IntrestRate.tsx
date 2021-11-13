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

    TotalLoan: number=10;
    NumberOfInstallments: number=1;
    PayPerMonth: number=1;
    IntrestRate: number;
    IntrestRateRef = React.createRef() as any;
    PayPerMonthRef = React.createRef() as any;
    LabelMessageRef = React.createRef() as any;

    handleIntrestRateChange = () => {
        console.log("Intrest Rate Input element changed");
    }

    handlePayPerMonthChange = ()=>{
        let responseUserInput = this.UpdateUserInput();
        if (responseUserInput.Status == ResponseStatus.Error) {
            //show error message to user

            return;
        }
        let responseCalculteRate = new LoanCalculotor().CalculateRate(this.TotalLoan, this.PayPerMonth, this.NumberOfInstallments);
        if (responseCalculteRate.Status == ResponseStatus.Error) {
            //show error message to user
            this.LabelMessageRef.current.innerText = responseCalculteRate.Message;
            return;
        }

        //update intrest rate fied
        this.IntrestRateRef.current.value = responseCalculteRate.Data;
    }

    UpdateUserInput(): Response<void> {
        let response = new Response<void>();
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
                    <input />
                </fieldset>
                 <fieldset>
                    <legend>تعداد اقساط</legend>
                    <input />
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

