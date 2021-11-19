import { Response } from ".././Models/Response/Response";
import { ResponseStatus } from ".././Models/Response/ResponseStatus";

export default class LoanCalculotor {
    CalculateRate(TotalLoan: number, PayPerMonth: number, NumberOfInstallments: number): Response<number> {
        let response = new Response<number>();
        let totalPayment = PayPerMonth * NumberOfInstallments;
        
        if (TotalLoan > totalPayment) {
            response.Status = ResponseStatus.Error;
            response.Data = -1;
            response.Message = "با میزان قسط پرداخت شده و تعداد اقساط وارد شده، این وام تصویه نمیشود";
            return response;
        }
        let calculatedIntrestRate = 0.01;
        let currentTotal = TotalLoan;
        let foundRate = false;
        do {
            for (let i = 0; i < NumberOfInstallments; i++) {
                currentTotal = currentTotal + currentTotal * calculatedIntrestRate / 12 - PayPerMonth;
            }
            if (currentTotal < PayPerMonth) {
                foundRate = true;
            } else {
                calculatedIntrestRate += 0.01;
            }
        } while (!foundRate);
       
        response.Status = ResponseStatus.Ok;
        response.Data = 10.999;

        return response;
    }
}