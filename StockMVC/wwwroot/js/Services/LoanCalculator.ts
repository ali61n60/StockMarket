import { Response } from ".././Models/Response/Response";
import { ResponseStatus } from ".././Models/Response/ResponseStatus";

export default class LoanCalculotor {
    calculatedIntrestRate = 1;//in percent
    maximumLoop = 100;

    CalculateRate(TotalLoan: number, PayPerMonth: number, NumberOfInstallments: number): Response<number> {
        let response = new Response<number>();
        let totalPayment = PayPerMonth * NumberOfInstallments;
        
        if (TotalLoan > totalPayment) {
            response.Status = ResponseStatus.Error;
            response.Data = -1;
            response.Message = "با میزان قسط پرداخت شده و تعداد اقساط وارد شده، این وام تصویه نمیشود";
            return response;
        }
        
        let currentTotal = TotalLoan;
        let problemSolved = false;
        for (let k = 0; k < this.maximumLoop;k++){
            for (let i = 0; i < NumberOfInstallments; i++) {
                currentTotal = currentTotal * (1 + this.calculatedIntrestRate / 1200) - PayPerMonth;
                console.log(currentTotal);
            }
            if (currentTotal < PayPerMonth*2 && currentTotal>0) {
                problemSolved = true;
                break;
            } else if (currentTotal > PayPerMonth) {
                currentTotal = TotalLoan;
                this.decrementRate();
                console.log("decrement"); 
            }
            else {
                currentTotal = TotalLoan;
                this.incrementRate();
                console.log("increment");                 
            }
        }
        if (problemSolved) {
            response.Status = ResponseStatus.Ok;
            response.Data = this.calculatedIntrestRate;
        }
        else {
            response.Status = ResponseStatus.Error;
            response.Message = "loop iterration completed without succeding";
        }

        return response;
    }

    private incrementRate() {
        this.calculatedIntrestRate += 1;
    }
    private decrementRate() {
        this.calculatedIntrestRate -= 1;
    }



}