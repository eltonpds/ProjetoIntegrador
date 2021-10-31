import { AppModule } from './../../app.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { VaccineComponent } from './vaccine.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormVaccineComponent } from './form-vaccine/form-vaccine.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [VaccineComponent, FormVaccineComponent]
})
export class VacinaModule { }
