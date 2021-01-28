import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { PdcEditModalComponent } from './pdc-edit-modal/pdc-edit-modal.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { PdcComponent } from './pdc.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../../../shared/share.module';

@NgModule({
    imports: [
        CommonModule,
        SharedModule,
        ModalModule.forRoot(),
    ],
    declarations: [
        PdcComponent,
        PdcEditModalComponent
    ],
    providers: [],
})
export class PDCModule { }
