import { MenuItem } from "../menu/menu-item.model";

export class OrderSummary {
  items: Array<MenuItem>;
  originalCost: number;
  totalCost: number;
  surcharge: number;
  discountAmount: number;
}
