import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MedicoIndexComponent } from './medico-index/medico-index.component';
import { MedicoCreateComponent } from './medico-create/medico-create.component';

@NgModule({
  declarations: [
    MedicoIndexComponent,
    MedicoCreateComponent
  ],
  imports: [
    CommonModule
  ]
})
export class MedicoModule { }
