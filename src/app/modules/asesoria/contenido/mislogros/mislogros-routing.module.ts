import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MislogrosComponent } from './mislogros.component';

const routes: Routes = [
  { path: '', component: MislogrosComponent }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MislogrosRoutingModule { }
