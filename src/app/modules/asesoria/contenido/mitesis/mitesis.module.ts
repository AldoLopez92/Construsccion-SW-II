import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MitesisComponent } from './mitesis.component';
import { MitesisRoutingModule } from './mitesis-routing.module';
import { MatToolbarModule } from '@angular/material';



@NgModule({
  declarations: [MitesisComponent],
  imports: [
    CommonModule,
    MitesisRoutingModule,
    MatToolbarModule
  ]
})
export class MitesisModule { }
