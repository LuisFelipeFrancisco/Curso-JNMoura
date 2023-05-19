import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MedicoCreateComponent } from './medico-create/medico-create.component';
import { MedicoEditComponent } from './medico-edit/medico-edit.component';
import { MedicoIndexComponent } from './medico-index/medico-index.component';


const routes: Routes = [
  {path:'', component:MedicoIndexComponent, pathMatch:'full'}, // pathMatch:'full' é necessário para que a rota vazia seja exibida
  {path:'medico-index', component:MedicoIndexComponent},
  {path:'medico-create', component:MedicoCreateComponent},
  {path:'medico-edit/:id', component:MedicoEditComponent},
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)], // forChild() pois não é o módulo principal da aplicação
  exports: [RouterModule]
})
export class MedicoRoutingModule { }
