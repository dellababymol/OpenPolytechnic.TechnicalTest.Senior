import { ChangeDetectionStrategy, Component, OnChanges, OnInit, SimpleChanges, ViewEncapsulation } from "@angular/core";
import { MatSelectChange } from "@angular/material";
import { Observable, of } from "rxjs";
import { CustomerType } from "../../enum/customer-type.enum";
import { MenuType } from "../../enum/menu-type.enum";
import { Menu } from "../../model/menu/menu.model";
import { OrderSummary } from "../../model/order/order-summary.model";
import { Order } from "../../model/order/order.model";
import { Orders } from "../../model/order/orders.model";
import { MenuService } from "../../service/menu/menu.service";
import { OrderService } from "../../service/order/order.service";

@Component({
  selector: 'op-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  encapsulation: ViewEncapsulation.None
})
export class OrderComponent implements OnInit {
  public orderSummary$: Observable<OrderSummary>;
  public MenuType = MenuType;
  public availableMenus: Array<string> =['standard', 'weekend', 'catering'];
  public chosenMenu: string;
  public currentMenu$: Observable<Menu>;
  public individualOrders: Array<Order>;
  public CustomerType = CustomerType;
  public customerTypes = [CustomerType.Child, CustomerType.Student, CustomerType.Standard, CustomerType.Senior];
  public orders$: Observable<Orders>;

  constructor(
    private menuService: MenuService,
    private orderService: OrderService) { }

    ngOnInit(): void {
      this.placeNewOrder();
    }

    onMenuSelect(chosenMenu: string) {
      if (!!chosenMenu) {
        this.currentMenu$ = this.menuService.getMenu(chosenMenu);
      }
      else {
        this.currentMenu$ = of(null);
      }
     }

  placeOrder(): void {
   
    this.individualOrders.forEach(x => x.menuItemIds = x.menuItemIds.filter(y => y != 0));
 
    this.orderSummary$ = this.orderService.placeOrder(
      {
        menuType: this.chosenMenu, individualOrders: this.individualOrders
      });  
    }

    addCustomer(): void {
      this.individualOrders.push({ customerType: CustomerType.Standard, menuItemIds: [] });
    }

    addItemForCustomer(customerIndex: number): void {
      if (!!this.individualOrders[customerIndex]) {
        this.individualOrders[customerIndex].menuItemIds.push(0);
      }
    }

    selectItemForOrder(changeEvent: MatSelectChange, customerIndex: number, individualOrderItemIndex: number) {
      this.individualOrders[customerIndex].menuItemIds[individualOrderItemIndex] = changeEvent.value;
    }

    placeNewOrder(): void {
      this.currentMenu$ = of(null);
      this.chosenMenu = null;
      this.orderSummary$ = of(null);
      this.individualOrders = [{ customerType: CustomerType.Standard, menuItemIds: [] }];
    }

    trackBy(index, val) {
      return index
    }  
}
