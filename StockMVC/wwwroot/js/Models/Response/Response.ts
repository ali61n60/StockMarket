import {ResponseStatus} from "../Response/ResponseStatus";

export class Response<T>{
    public Data: T;
    public Status: ResponseStatus;
    public Message: string;
}

