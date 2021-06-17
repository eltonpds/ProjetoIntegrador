import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { PacienteComponent } from './paciente.component';
import { PacientFormComponent } from './pacient-form/pacient-form.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  declarations: [PacienteComponent, PacientFormComponent]
})
export class PacientModule { }
