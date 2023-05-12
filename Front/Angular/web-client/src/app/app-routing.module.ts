import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { MedicoCreateComponent } from './components/medico/medico-create/medico-create.component';
import { MedicoIndexComponent } from './components/medico/medico-index/medico-index.component';
import { MensagemErro404Component } from './components/mensagem/mensagem-erro404/mensagem-erro404.component';
import { PacienteCreateComponent } from './components/paciente/paciente-create/paciente-create.component';
import { PacienteIndexComponent } from './components/paciente/paciente-index/paciente-index.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'medico-index', component:MedicoIndexComponent},
  {path:'medico-create', component:MedicoCreateComponent},
  {path:'paciente-index', component:PacienteIndexComponent},
  {path:'paciente-create', component:PacienteCreateComponent},
  {path:'**', component:MensagemErro404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
