import { Router } from '@angular/router';
import { Component, Inject, OnInit } from '@angular/core';

import { State } from 'src/app/core/model/enum/stateEnum';
import { FuncionarioService } from '../funcionario.service';
import { Employee } from '../../../core/model/employee';
import { Office } from './../../../core/model/enum/office';

@Component({
  selector: 'app-cadastro.funcionario',
  templateUrl: './cadastro.funcionario.component.html',
  styleUrls: ['./cadastro.funcionario.component.css']
})
export class CadastroFuncionarioComponent implements OnInit {

  employee: Employee;
  offices = Object.values(Office);
  states = Object.values(State);

  constructor(private _funcionarioService: FuncionarioService, private _router: Router) {
   }

  ngOnInit() {
    this.employee = new Employee();
  }

  public voltar() {
    this._router.navigate(['/funcionario']);
  }
  
  public register(state, office) {
    this.employee.state = state;
    this.employee.office = office;
    this._funcionarioService.registerEmployee(this.employee)
    .subscribe(
      employeeJson => {
        this.employee = employeeJson,
        this.voltar();
      },
      e => {
        console.log(e)
      }
    );
  }

}
