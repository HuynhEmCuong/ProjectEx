import { NgModule } from "@angular/core";
import { UserComponent } from './user/user.component';
import { PdcComponent } from './pdc/pdc.component';
import { CommonModule } from "@angular/common";
import { PageRoutingModule } from "./pages.routing.module";
import { BuildingComponent } from "./building/building.component";


@NgModule({
    imports:[
        CommonModule,
        PageRoutingModule
    ],
    declarations:[UserComponent, PdcComponent,BuildingComponent],

})

export class PageModule {}