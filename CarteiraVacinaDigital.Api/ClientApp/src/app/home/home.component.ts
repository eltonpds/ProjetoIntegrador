import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Office, OfficeLabelMapping } from '../core/model/enum/office';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public employee;
  public officeName: string;
  OfficeLabelMapping = OfficeLabelMapping;
  
  constructor(private _router: Router) {
    let employeeSession = sessionStorage.getItem('employeeSession');
    if (employeeSession) {
      this.employee = JSON.parse(employeeSession);
      this.officeName =  Office[this.employee.office];
      
      switch (this.employee.office) {
        case 0: {
          this.officeName = Office.Administrador;
          break;
        }
        case 1: {
          this.officeName = Office.Tecnico;
          break;
        }
        case 2: {
          this.officeName = Office.Enfermeiro;
          break;
        } 
        case 3: {
          this.officeName = Office.Medico;
          break;
        }
        case 4: {
          this.officeName = Office.Aprendiz;
          break;
        }
        case 5: {
          this.officeName = Office.Estagiario;
          break;
        }
      }
    } else {
      this._router.navigate(['/login']);
    }
  }

  ngOnInit() {

  }

}
