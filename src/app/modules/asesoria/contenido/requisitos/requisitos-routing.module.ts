import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RequisitosComponent } from './requisitos.component';

const routes: Routes = [
  { path: '', component: RequisitosComponent }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RequisitosRoutingModule { }
