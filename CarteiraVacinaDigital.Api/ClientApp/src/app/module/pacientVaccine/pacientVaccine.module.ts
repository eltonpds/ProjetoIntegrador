import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PacientVaccineComponent } from './pacient-vaccine.component';
import { RegisterVaccineComponent } from './register-vaccine/register-vaccine.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [PacientVaccineComponent, RegisterVaccineComponent]
})
export class PacientVaccineModule { }
