import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';

import { Employee } from 'src/app/core/model/employee';
import { OfficeEnum } from 'src/app/core/model/enum/office';

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService {
    
  private _baseUrl: string;
  private _employees: Employee[];
  private _employee: Employee;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl:string) {
    this._baseUrl = baseUrl;
   }

   get headers(): HttpHeaders {
     return new HttpHeaders().set('content-type', 'application/json');
   }

   public login(employee: Employee): Observable<Employee> {
    return this.http.post<Employee>(this._baseUrl + 'api/employee/login', JSON.stringify(employee), { headers: this.headers });
  }

  get getEmployeeSession(): Employee {
    let employeeSession = sessionStorage.getItem('employeeSession');
    
    if (employeeSession != null) {
      this._employee = JSON.parse(employeeSession);
      return this._employee;
    }
    else {
      employeeSession = "";
    }
  }

  set setEmployeeSession(employee: Employee) {    
    employee.OfficeName = OfficeEnum[employee.Office];
    sessionStorage.setItem('employeeSession', JSON.stringify(employee));
    this._employee = employee;
  }

  employeeAuthenticated(): boolean {
    this.getEmployeeSession;

    if (this._employee != null && this._employee.Email != '' && this._employee.Password != '')
      return true 
    else 
      return false;
  }

   getEmployee():Observable<Employee[]> {     
    return this.http.get<Employee[]>(this._baseUrl + 'api/employee/getallemployee');
  }

  public registerEmployee(employee: Employee): Observable<Employee> {    
    return this.http.post<Employee>(this._baseUrl + 'api/employee/registeremployee', JSON.stringify(employee), {headers: this.headers});
  }

  clearSession() {
    sessionStorage.setItem('employeeSession', ' ');
    this._employee = null;
  }
}
