import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { PacientVaccine } from 'src/app/core/model/pacientVaccine';

@Injectable({
  providedIn: 'root'
})
export class PacientVaccineService {
  private _baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this._baseUrl = baseUrl;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public registrarPacienteVacinado(pacientVaccine: PacientVaccine): Observable<PacientVaccine> {
    return this.http.post<PacientVaccine>(this._baseUrl + 'api/pacientVaccine/RegisterPacientVaccine', JSON.stringify(pacientVaccine), {headers: this.headers});
  }
  
  getPacientsVaccinated(): Observable<PacientVaccine[]> {
    return this.http.get<PacientVaccine[]>(this._baseUrl + 'api/PacientVaccine');
  }

}
