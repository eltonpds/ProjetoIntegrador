import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FuncionarioService } from 'src/app/module/funcionario/funcionario.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private _router: Router, private _employeeService: FuncionarioService) { }

  ngOnInit() {
  }
  
  public userLogged(): boolean {
    return this._employeeService.employeeAuthenticated();
  }

  get employee() { 
    return this._employeeService.getEmployeeSession;
  }

  entrar () {
    this._router.navigate(['/login']);
  }
  
  sair() {
    this._employeeService.clearSession();
    sessionStorage.setItem("employeeSession", "");
    this._router.navigate(['/login']);
  }

}