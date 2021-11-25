import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';

import { Calender } from 'src/app/core/model/calender';
import { Vaccine } from 'src/app/core/model/vaccine';
import { CalendarioService } from 'src/app/module/calendario/calendario.service';
import { VaccineService } from '../../vaccine/vaccine.service';

@Component({
  selector: 'app-form-calendario',
  templateUrl: './form-calendario.component.html',
  styleUrls: ['./form-calendario.component.css']
})
export class FormCalendarioComponent implements OnInit {

  calender: Calender;
  vaccines: Vaccine[];
  public activateSpinner: boolean;

  constructor(private _calenderService: CalendarioService, private _vaccineService: VaccineService, private _router: Router, private _toastr: ToastrService) { 
    this.activateSpinner = true;
    this._vaccineService.getVaccine()
      .subscribe(
        result => {
          this.activateSpinner = false;
          this.vaccines = result;
        },
        e => {
          this._toastr.error('Não foi possível concluir a solicitação', 'Erro de conexão');
          this.activateSpinner = false;
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
    this.calender.VaccineID = Number(this.calender.VaccineID);
    this._calenderService.registerCalender(this.calender)
    .subscribe(
      calenderJson => {
        this.calender = calenderJson,
        this._toastr.success('Calendário cadastrado', 'Sucesso');
        this.voltar();
      },
      e => {
        this._toastr.error('Não foi possível concluir a solicitação', 'Erro de conexão');
      }
    );
  }

}
