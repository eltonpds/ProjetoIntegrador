import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Pacient } from 'src/app/core/model/pacient';

@Injectable({
  providedIn: 'root'
})
export class PacientService {

 private _baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this._baseUrl = baseUrl;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public getPacient(): Observable<Pacient[]> {
    return this.http.get<Pacient[]>(this._baseUrl + 'api/pacient');
  }
  
  public registerPacient(pacient: Pacient): Observable<Pacient> {
    return this.http.post<Pacient>(this._baseUrl + 'api/pacient/registerpacient', JSON.stringify(pacient), {headers: this.headers});
  }
}
