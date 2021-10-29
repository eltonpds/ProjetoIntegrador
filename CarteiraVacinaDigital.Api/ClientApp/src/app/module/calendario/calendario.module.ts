import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { FormCalendarioComponent } from './form-calendario/form-calendario.component';
import { CalendarioComponent } from './calendario.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [CalendarioComponent, FormCalendarioComponent]
})
export class CalendarioModule { }
