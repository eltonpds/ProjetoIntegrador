import { AppModule } from './../../app.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { VaccineComponent } from './vaccine.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [VaccineComponent]
})
export class VacinaModule { }
