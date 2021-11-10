import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/core/model/employee';
import { State } from 'src/app/core/model/enum/stateEnum';
import { Pacient } from 'src/app/core/model/pacient';
import { VaccineService } from '../../vacina/vaccine.service';
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
  activateSpinner: boolean;

  constructor(private _pacientService: PacientService, private _router: Router) {
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
    this.pacient.state = state;
    this._pacientService.registerPacient(this.pacient)
    .subscribe(
      pacientJson => {
        this.pacient = pacientJson,
        this.activateSpinner = false,
        this.voltar();
      },
      e => {
        this.activateSpinner = false;
      }
    );
  }

}
