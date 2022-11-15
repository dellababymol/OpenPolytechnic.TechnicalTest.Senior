import { ChangeDetectionStrategy, Component, OnChanges, OnInit, SimpleChanges } from "@angular/core";
import { ActivatedRoute, ParamMap } from "@angular/router";
import { merge, Observable, of } from "rxjs";
import { map, switchMap } from "rxjs/operators";
import { Menu } from "../../model/menu/menu.model";
import { MenuService } from "../../service/menu/menu.service";

@Component({
  selector: 'op-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class MenuComponent implements OnInit {

  public menu$: Observable<Menu>;

  constructor(private menuService: MenuService, private activatedRoute: ActivatedRoute) { }

    ngOnInit(): void {
      this.menu$ = this.activatedRoute.paramMap.pipe(
        switchMap((params: ParamMap) =>
          merge(
            of(null),
            this.menuService.getMenu(params.get('id'))
          )));
    }
}
