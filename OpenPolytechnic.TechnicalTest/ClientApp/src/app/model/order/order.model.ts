import { CustomerType } from "../../enum/customer-type.enum";

export class Order {
  customerType: CustomerType;
  menuItemIds: Array<number>;
}
