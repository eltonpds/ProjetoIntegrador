import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FuncionarioService } from 'src/app/module/funcionario/funcionario.service';
import { Employee } from '../model/employee';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public pacient;
  public employee;
  public returnUrl: string;
  public msg: string;
  public ativar_spinner: boolean;

  constructor(private _router: Router, private activatedRouter: ActivatedRoute, private _employeeService: FuncionarioService) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    sessionStorage.setItem('employeeSession', '');
    this.employee = new Employee();
  }

  public entrar() {
    this.ativar_spinner = true;
    this._employeeService.login(this.employee)
      .subscribe(
        employeeJson => {
          this.employee = employeeJson;

          if (this.returnUrl == null) {
            this._router.navigate(['/']);
          } else {
            this._router.navigate([this.returnUrl]);
          }

          sessionStorage.setItem('employeeSession', JSON.stringify(this.employee));
        }, err => {
          this.msg = err.error;
          this.ativar_spinner = false;
        }
    );
  }

}