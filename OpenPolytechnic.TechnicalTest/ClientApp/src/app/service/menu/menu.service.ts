import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Menu } from "../../model/menu/menu.model";

@Injectable()
export class MenuService {

  constructor(private httpClient: HttpClient) { }

  public getMenu(menuType: string): Observable<Menu> {
    return this.httpClient.get<Menu>(`/api/menu/${menuType}`);
  }
}
