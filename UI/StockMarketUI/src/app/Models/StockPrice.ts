import { Time } from '@angular/common';

export interface StockPrice {
    RowId:number;
    CompanyCode:string;
    StockExchange:string;
    CurrentPrice:number;
    Date:Date;
    Time:Time;
}
