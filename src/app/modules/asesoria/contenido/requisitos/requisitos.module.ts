import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import {RequisitosRoutingModule} from './requisitos-routing.module';
import { RequisitosComponent } from './requisitos.component';
import { MatToolbarModule, MatCardModule } from '@angular/material';



@NgModule({
  declarations: [
    RequisitosComponent
  ],
  imports: [
    CommonModule,
    RequisitosRoutingModule,
    MatToolbarModule,
    MatCardModule
  ]
})
export class RequisitosModule { }
