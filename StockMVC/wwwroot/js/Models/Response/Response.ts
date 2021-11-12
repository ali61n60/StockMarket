import {ResponseStatus} from "ResponseStatus";

export class Response<T>{
    public Data: T;
    public Status: ResponseStatus;
}

