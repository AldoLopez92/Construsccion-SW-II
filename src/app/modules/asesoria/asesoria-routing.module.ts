import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AsesoriaComponent } from './asesoria.component';

const routes: Routes = [

  { 
    path: '',
    component: AsesoriaComponent ,    
    children:[
      {
        path:'',
        loadChildren: () => import('./contenido/contenido.module').then(m => m.ContenidoModule)
      }
    ]
  },  
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AsesoriaRoutingModule { }
