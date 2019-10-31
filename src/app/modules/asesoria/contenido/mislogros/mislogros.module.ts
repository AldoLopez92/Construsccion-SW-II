import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MislogrosComponent } from './mislogros.component';
import { MislogrosRoutingModule } from './mislogros-routing.module';
import { MatToolbarModule, MatCardModule } from '@angular/material';
import {MatGridListModule} from '@angular/material/grid-list';



@NgModule({
  declarations: [MislogrosComponent],
  imports: [
    CommonModule,
    MislogrosRoutingModule,
    MatToolbarModule,
    MatCardModule,
    MatGridListModule
  ]
})
export class MislogrosModule { }
