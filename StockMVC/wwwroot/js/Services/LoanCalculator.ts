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

        response.Status = ResponseStatus.Ok;
        response.Data = 10.999;

        return response;
    }
}