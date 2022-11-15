import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

const routes: Routes = [
  {
    path: 'menu',
    loadChildren: () => import('./components/menu/menu.module').then(m => m.MenuModule)
  },
  {
    path: 'order',
    loadChildren: () => import('./components/order/order.module').then(m => m.OrderModule)
  }
]

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy', scrollPositionRestoration: 'enabled' })],
  exports: [RouterModule]
})
export class AppRouterModule { }
