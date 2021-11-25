import { Router } from '@angular/router';
import { Component, Inject, OnInit } from '@angular/core';

import { ToastrService } from 'ngx-toastr';

import { State, StateEnum, StateLabelMapping } from 'src/app/core/model/enum/stateEnum';
import { FuncionarioService } from '../funcionario.service';
import { Employee } from '../../../core/model/employee';
import { Office, OfficeEnum, OfficeLabelMapping } from './../../../core/model/enum/office';

@Component({
  selector: 'app-cadastro.funcionario',
  templateUrl: './cadastro.funcionario.component.html',
  styleUrls: ['./cadastro.funcionario.component.css']
})
export class CadastroFuncionarioComponent implements OnInit {

  employee: Employee;

  office = Office;
  state = State;
  offices = Object.values(Office);
  OfficeLabelMapping = OfficeLabelMapping;
  StateLabelMapping = StateLabelMapping;
  states = Object.values(State);
  statesEnum: StateEnum[];
  officesEnum: OfficeEnum[];

  public msg: string;
  public activateSpinner: boolean;

  constructor(private _funcionarioService: FuncionarioService, private _router: Router, private _toastr: ToastrService) {
    let employeeSession = sessionStorage.getItem('employeeSession');

    if (employeeSession) 
      this.employee = JSON.parse(employeeSession);
    else 
      this.employee = new Employee();
   }

  ngOnInit() {
    this.employee = new Employee();
  }

  public voltar() {
    this._router.navigate(['/funcionario']);
  }
  
  public register(state, office) {
    this.activateSpinner = true;
    this.employee.State = parseInt(StateEnum[state]);
    this.employee.Office = parseInt(OfficeEnum[office]);
    this._funcionarioService.registerEmployee(this.employee)
    .subscribe(
      employeeJson => {
        this.employee = employeeJson,
        this.activateSpinner = false,
        this._toastr.success('Funcionário cadastrado', 'Sucesso');
        this.voltar();
      },
      e => {
        this._toastr.error('Não foi possível concluir a solicitação', 'Erro de conexão');
        this.activateSpinner = false;
      }
    );
  }

}
