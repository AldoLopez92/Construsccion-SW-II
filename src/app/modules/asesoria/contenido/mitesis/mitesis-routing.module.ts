import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MitesisComponent } from './mitesis.component';

const routes: Routes = [
  { path: '', component: MitesisComponent }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MitesisRoutingModule { }
