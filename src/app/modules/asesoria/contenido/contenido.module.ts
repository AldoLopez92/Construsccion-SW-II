import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon'
import {MatGridListModule} from '@angular/material/grid-list';
import { RouterModule, Routes } from '@angular/router';
import { ContenidoRoutingModule } from './contenido-routing.module';
import { MatCard } from '@angular/material';

@NgModule({
  declarations: [   
    
    ],
  imports: [
    CommonModule,
    ContenidoRoutingModule,
    MatSidenavModule,
    MatListModule,
    MatIconModule,
    MatGridListModule,
    RouterModule    
  ]
})
export class ContenidoModule { }
