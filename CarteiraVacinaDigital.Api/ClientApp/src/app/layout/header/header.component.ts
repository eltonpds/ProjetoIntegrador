import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Location } from '@angular/common';
import { FuncionarioService } from 'src/app/module/funcionario/funcionario.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  userLogged: boolean;

  constructor(private _router: Router, private _employeeService: FuncionarioService, private _location: Location) { 
  }

  ngOnInit() {
  }

  get employee() { 
    let employeeSession =  this._employeeService.getEmployeeSession;

    if (employeeSession != null) {
      this.userLogged = true;
      return employeeSession;
    }
    else {
      this.userLogged = false;
      this.entrar();
    }
  }

  entrar () {
    this._router.navigate(['/login']);
  }
   
  sair() {
    this._employeeService.clearSession();
    sessionStorage.setItem("employeeSession", "");
    this._router.navigate(['/login']);
  }

  isLoginRouteActivated(): boolean{
    return this._location.path() === '/login';
}

}