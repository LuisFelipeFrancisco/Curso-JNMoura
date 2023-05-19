import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PacienteCreateComponent } from './paciente-create/paciente-create.component';
import { PacienteIndexComponent } from './paciente-index/paciente-index.component';

const routes: Routes = [
  {path:'', component:PacienteIndexComponent, pathMatch:'full'}, // pathMatch:'full' é necessário para que a rota vazia seja exibida
  {path:'paciente-index', component:PacienteIndexComponent},
  {path:'paciente-create', component:PacienteCreateComponent}
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)], // forChild() pois não é o módulo principal da aplicação
  exports: [RouterModule]
})
export class PacienteRoutingModule { }
