import { Response } from ".././Models/Response/Response";
import { ResponseStatus } from ".././Models/Response/ResponseStatus";

export default class LoanCalculotor {
    CalculateRate(TotalLoan: number, PayPerMonth: number): Response<number> {
        let response = new Response<number>();
        response.Status = ResponseStatus.Ok;
        response.Data = 10.999;

        return response;
    }
}