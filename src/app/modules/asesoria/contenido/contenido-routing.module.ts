import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: 'especialidades',
    loadChildren: () => import('./especialidades/especialidades.module').then(m => m.EspecialidadesModule)
  },
  {
    path: 'mislogros',
    loadChildren: () => import('./mislogros/mislogros.module').then(m => m.MislogrosModule)
  },
  {
    path: 'mitesis',
    loadChildren: () => import('./mitesis/mitesis.module').then(m => m.MitesisModule)
  },
  {
    path: 'requisitos',    
    loadChildren: () => import('./requisitos/requisitos.module').then(m => m.RequisitosModule)
  },
  {
    path:'',
    redirectTo: 'especialidades'
  }          
  
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContenidoRoutingModule { }
