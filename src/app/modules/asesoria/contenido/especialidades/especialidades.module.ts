import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspecialidadesComponent } from './especialidades.component';
import { EspecialidadesRoutingModule } from './especialidades-routing.module';
import { MatToolbarModule, MatTabsModule,MatCardModule, MatGridListModule } from '@angular/material';

import { MatToolbarGroupAreasComponent } from './mat-toolbar-group-areas/mat-toolbar-group-areas.component';



@NgModule({
  declarations: [EspecialidadesComponent, MatToolbarGroupAreasComponent],
  imports: [
    CommonModule,
    EspecialidadesRoutingModule,
    MatToolbarModule,
    MatTabsModule,
    MatCardModule,
    MatGridListModule
  ]
})
export class EspecialidadesModule { }
