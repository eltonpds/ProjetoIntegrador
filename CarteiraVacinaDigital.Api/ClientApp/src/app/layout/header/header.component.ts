import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private _router: Router) { }

  ngOnInit() {
  }
  
  public userLogged(): boolean {
    if (sessionStorage.getItem("employeeSession"))
      return true;

    // var userLogged = sessionStorage.getItem("funcionario-autenticado");
    // if (userLogged == "1") {
    //   return true;
    // }
    // return false;
  }
  entrar () {
    this._router.navigate(['/login']);
  }
  
  sair() {
    sessionStorage.setItem("employeeSession", "");
    this._router.navigate(['/login']);
  }

}