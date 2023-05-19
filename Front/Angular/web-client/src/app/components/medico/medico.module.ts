import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MedicoIndexComponent } from './medico-index/medico-index.component';
import { MedicoCreateComponent } from './medico-create/medico-create.component';
import { FormsModule } from '@angular/forms';
import { MedicoEditComponent } from './medico-edit/medico-edit.component';
import { MedicoRoutingModule } from './medico-routing.module';

@NgModule({
  declarations: [
    MedicoIndexComponent,
    MedicoCreateComponent,
    MedicoEditComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    MedicoRoutingModule
  ]
})
export class MedicoModule { }
