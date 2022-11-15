import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { catchError } from "rxjs/operators";
import { OrderSummary } from "../../model/order/order-summary.model";
import { Orders } from "../../model/order/orders.model";

@Injectable()
export class OrderService {

  constructor(private httpClient: HttpClient) { }

  public placeOrder(orders: Orders): Observable<OrderSummary> {
    return this.httpClient.post<OrderSummary>('/api/order/place', orders);    
  }
}

