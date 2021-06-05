import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';

import { Employee } from 'src/app/core/model/employee';

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService {
  private _baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl:string) {
    this._baseUrl = baseUrl;
   }

   get headers(): HttpHeaders {
     return new HttpHeaders().set('content-type', 'application/json');
   }

  public registerEmployee(employee: Employee): Observable<Employee> {
    return this.http.post<Employee>(this._baseUrl + 'api/employee/registeremployee', JSON.stringify(employee), {headers: this.headers});
  }
}