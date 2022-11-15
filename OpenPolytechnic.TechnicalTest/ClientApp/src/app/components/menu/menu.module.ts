import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MenuService } from "../../service/menu/menu.service";
import { MenuComponent } from "./menu.component";
import { MenuRouterModule } from "./menu.routing";

@NgModule({
  imports: [
    CommonModule,
    MenuRouterModule
  ],
  declarations: [
    MenuComponent
  ],
  providers: [
    MenuService
  ]
})
export class MenuModule { }
