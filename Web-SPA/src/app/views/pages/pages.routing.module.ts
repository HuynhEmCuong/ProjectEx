import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuildingComponent } from './building/building.component';
import { UserComponent } from './user/user.component';

export const routes: Routes = [
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
    }
]


@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class PageRoutingModule { }