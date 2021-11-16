import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Vaccine } from 'src/app/core/model/vaccine';

@Injectable({
  providedIn: 'root'
})
export class VaccineService {

  private _baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this._baseUrl = baseUrl;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public getVaccine(): Observable<Vaccine[]> {
    return this.http.get<Vaccine[]>(this._baseUrl + 'api/Vaccine');
  }
  
  public registerVaccine(vaccine: Vaccine): Observable<Vaccine> {
    return this.http.post<Vaccine>(this._baseUrl + 'api/Vaccine/registerVaccine', JSON.stringify(vaccine), {headers: this.headers});
  }
}
