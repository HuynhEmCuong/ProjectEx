import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
    imports: [
        ReactiveFormsModule,
        HttpClientModule,
    ],
    exports: [FormsModule, ReactiveFormsModule,],
    declarations: [],
    providers: [],
})
export class SharedModule { }
