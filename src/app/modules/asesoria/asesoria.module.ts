import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AsesoriaRoutingModule } from './asesoria-routing.module';
import { AsesoriaComponent } from './asesoria.component';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon'
import {MatGridListModule} from '@angular/material/grid-list';
import { RouterModule, Routes } from '@angular/router';
import { NavegacionLateralComponent } from './navegacion-lateral/navegacion-lateral.component';

@NgModule({
  declarations: [
    AsesoriaComponent,
    NavegacionLateralComponent, 
  ],
  imports: [
    CommonModule,
    AsesoriaRoutingModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatGridListModule,
    RouterModule
  ]
})
export class AsesoriaModule { }
