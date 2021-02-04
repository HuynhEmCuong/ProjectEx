import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuildingComponent } from './building/building.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PdcComponent } from './pdc/pdc.component';
import { UserComponent } from './user/user.component';

export const routes: Routes = [
    {
        path: '',
        component: DashboardComponent,
        data: {
            title: 'dasboard'
        }
    },
    {
        path: 'user',
        component: UserComponent,
        data: {
            title: 'user'
        }
    },
    {
        path: 'building ',
        component: BuildingComponent,
        data: {
            title: 'building'
        }
    },
    {
        path: 'pdc',
        component: PdcComponent,
        data: {
            title: 'PDC'
        },

    },
    { path: '**', component: DashboardComponent },
    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },

]

  
  

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class PageRoutingModule { }