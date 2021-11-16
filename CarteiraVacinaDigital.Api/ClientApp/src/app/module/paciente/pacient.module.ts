import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { NgxMaskModule } from 'ngx-mask';

import { PacienteComponent } from './paciente.component';
import { PacientFormComponent } from './pacient-form/pacient-form.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgxMaskModule.forChild()
  ],
  declarations: [PacienteComponent, PacientFormComponent]
})
export class PacientModule { }
