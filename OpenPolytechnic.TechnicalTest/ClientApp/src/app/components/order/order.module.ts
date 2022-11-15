import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MatButtonModule, MatSelectModule } from "@angular/material";
import { MenuService } from "../../service/menu/menu.service";
import { OrderService } from "../../service/order/order.service";
import { OrderComponent } from "./order.component";
import { OrderRouterModule } from "./order.routing";

@NgModule({
  imports: [
    CommonModule,
    OrderRouterModule,
    MatSelectModule,
    MatButtonModule
  ],
  declarations: [
    OrderComponent
  ],
  providers: [
    MenuService,
    OrderService
  ]
})
export class OrderModule { }
