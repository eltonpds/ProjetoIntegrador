import { Router } from '@angular/router';
import { FuncionarioService } from '../funcionario.service';
import { Employee } from '../../../core/model/employee';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-cadastro.funcionario',
  templateUrl: './cadastro.funcionario.component.html',
  styleUrls: ['./cadastro.funcionario.component.css']
})
export class CadastroFuncionarioComponent implements OnInit {

  employee: Employee;
  private _baseUrl: string;
  constructor(private _funcionarioService: FuncionarioService, @Inject('BASE_URL')baseUrl: string, private _router: Router) {
    this._baseUrl = baseUrl;
   }

  ngOnInit() {
  }

  public voltar() {
    this._router.navigate(['/funcionario']);
  }
  public register() {
    this._funcionarioService.registerEmployee(this.employee)
    .subscribe(
      employeeJson => {
        this.employee = employeeJson,
        console.log(this.employee)
      },
      e => {
        console.log(e)
      }
    );
  }

}
