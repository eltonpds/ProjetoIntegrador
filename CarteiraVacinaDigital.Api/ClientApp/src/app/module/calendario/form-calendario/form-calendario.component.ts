import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Calender } from 'src/app/core/model/calender';
import { Vaccine } from 'src/app/core/model/vaccine';
import { CalendarioService } from 'src/app/module/calendario/calendario.service';
import { VaccineService } from '../../vacina/vaccine.service';

@Component({
  selector: 'app-form-calendario',
  templateUrl: './form-calendario.component.html',
  styleUrls: ['./form-calendario.component.css']
})
export class FormCalendarioComponent implements OnInit {

  calender: Calender;
  vaccines: Vaccine[];

  constructor(private _calenderService: CalendarioService, private _vaccineService: VaccineService, private _router: Router) { 
    this._vaccineService.getVaccine()
      .subscribe(
        result => {
          this.vaccines = result
        },
        e => {
        }
      );
  }

  ngOnInit() {
    this.calender = new Calender();
  }

  public voltar() {
    this._router.navigate(['/calendario']);
  }
  
  public registerCalendario() {
    this._calenderService.registerCalender(this.calender)
    .subscribe(
      calenderJson => {
        this.calender = calenderJson,
        this.voltar();
      },
      e => {
      }
    );
  }

}
