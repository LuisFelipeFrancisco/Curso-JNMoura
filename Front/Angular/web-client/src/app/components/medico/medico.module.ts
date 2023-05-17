import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MedicoIndexComponent } from './medico-index/medico-index.component';
import { MedicoCreateComponent } from './medico-create/medico-create.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    MedicoIndexComponent,
    MedicoCreateComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ]
})
export class MedicoModule { }
