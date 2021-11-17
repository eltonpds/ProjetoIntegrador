import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { PacientVaccineComponent } from './pacient-vaccine.component';
import { RegisterVaccineComponent } from './register-vaccine/register-vaccine.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [PacientVaccineComponent, RegisterVaccineComponent]
})
export class PacientVaccineModule { }
