import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../core/model/employee';

import { Office, OfficeEnum, OfficeLabelMapping } from '../core/model/enum/office';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public employee: Employee;
  public officeName: string;
  OfficeLabelMapping = OfficeLabelMapping;
  
  constructor(private _router: Router) {
    let employeeSession = sessionStorage.getItem('employeeSession');
    if (employeeSession) {
      this.employee = JSON.parse(employeeSession);
    } else {
      this._router.navigate(['/login']);
    }
  }

  ngOnInit() {

  }

}
