import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PacienteIndexComponent } from './paciente-index/paciente-index.component';
import { PacienteCreateComponent } from './paciente-create/paciente-create.component';



@NgModule({
  declarations: [
    PacienteIndexComponent,
    PacienteCreateComponent
  ],
  imports: [
    CommonModule
  ]
})
export class PacienteModule { }
