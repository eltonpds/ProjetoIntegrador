import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Calender } from 'src/app/core/model/calender';

@Injectable({
  providedIn: 'root'
})
export class CalendarioService {

  private _baseUrl: string;
  public calender: Calender[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl:string) {
    this._baseUrl = baseUrl;
   }

   get headers(): HttpHeaders {
     return new HttpHeaders().set('content-type', 'application/json');
   }

   getCalender():Observable<Calender[]> {     
    return this.http.get<Calender[]>(this._baseUrl + 'api/calender');
  }

  public registerCalender(calender: Calender): Observable<Calender> {    
    return this.http.post<Calender>(this._baseUrl + 'api/calender/registerCalender', JSON.stringify(calender), {headers: this.headers});
  }
}
