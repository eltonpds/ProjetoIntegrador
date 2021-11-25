import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';

import { Employee } from 'src/app/core/model/employee';
import { State, StateEnum } from 'src/app/core/model/enum/stateEnum';
import { Pacient } from 'src/app/core/model/pacient';
import { PacientService } from '../pacient.service';

@Component({
  selector: 'app-pacient-form',
  templateUrl: './pacient-form.component.html',
  styleUrls: ['./pacient-form.component.css']
})
export class PacientFormComponent implements OnInit {

  pacient: Pacient;  
  private _employee: Employee;
  states = Object.values(State);
  statesEnum: StateEnum[];
  activateSpinner: boolean;

  constructor(private _pacientService: PacientService, private _router: Router, private _toastr: ToastrService) {
    let employeeSession = sessionStorage.getItem('employeeSession');

    if (employeeSession) 
      this._employee = JSON.parse(employeeSession);
    else 
      this._employee = new Employee();
   }

  ngOnInit() {
    this.pacient = new Pacient();
  }  

  public voltar() {
    this._router.navigate(['/paciente']);
  }

  public register(state) { 
    this.activateSpinner = true;
    this.pacient.State = parseInt(StateEnum[state]);
    this._pacientService.registerPacient(this.pacient)
    .subscribe(
      pacientJson => {
        this.pacient = pacientJson,
        this.activateSpinner = false,
        this._toastr.success('Paciente cadastrado', 'Sucesso');
        this.voltar();
      },
      e => {
        this._toastr.error('Não foi possível concluir a solicitação');
        this.activateSpinner = false;
      }
    );
  }

}
