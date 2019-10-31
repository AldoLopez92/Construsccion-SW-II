import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AutenticacionRoutingModule } from './autenticacion-routing.module';
import { AutenticacionComponent } from './autenticacion.component';

import { MatCardModule, MatButtonModule, MatProgressBarModule } from '@angular/material';
import { MatInputModule } from '@angular/material';
import { FormsModule } from '@angular/forms';

import { MatToolbarModule } from '@angular/material';


@NgModule({
  declarations: [
    AutenticacionComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    AutenticacionRoutingModule,
    MatCardModule,
    MatInputModule,
    MatButtonModule,    
    MatProgressBarModule,
    MatToolbarModule
  ]
})
export class AutenticacionModule { }
