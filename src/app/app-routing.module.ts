import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'inicio',
    loadChildren: () => import('./modules/inicio/inicio.module').then(m => m.InicioModule)
  },

  {
    path: 'asesoria',
    loadChildren: () => import('./modules/asesoria/asesoria.module').then(m => m.AsesoriaModule)
  },

  {
    path: 'autenticacion',
    loadChildren: () => import('./modules/autenticacion/autenticacion.module').then(m => m.AutenticacionModule)
  },

  { path: '', redirectTo: 'autenticacion', pathMatch: 'full' }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }
