import { NgModule } from "@angular/core";
import { UserComponent } from './user/user.component';
import { PdcComponent } from './pdc/pdc.component';
import { CommonModule } from "@angular/common";
import { PageRoutingModule } from "./pages.routing.module";
import { BuildingComponent } from "./building/building.component";
import { DashboardComponent } from "./dashboard/dashboard.component";
import { PDCModule } from "./pdc/pdc.module";
import { SharedModule } from "../../core/shared/share.module";
import { FormsModule } from "@angular/forms";


@NgModule({
    imports: [
        CommonModule,
        // SharedModule,
        FormsModule,
        PageRoutingModule,
        PDCModule
    ],
    declarations: [
        UserComponent,
        BuildingComponent,
        DashboardComponent,
    ],

})

export class PageModule { }