import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Pacient } from 'src/app/core/model/pacient';
import { Vaccine } from 'src/app/core/model/vaccine';
import { PacientService } from '../paciente/pacient.service';
import { VaccineService } from '../vacina/vaccine.service';

@Component({
  selector: 'app-register-vaccine',
  templateUrl: './register-vaccine.component.html',
  styleUrls: ['./register-vaccine.component.css']
})
export class RegisterVaccineComponent implements OnInit {

  private _baseUrl: string;
  pacients: Pacient[];
  vaccines: Vaccine[];

  constructor(private _vaccineService: VaccineService, private _pacienteService: PacientService, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this._baseUrl = baseUrl;
    this._vaccineService.getVaccine()
    .subscribe(
      resultVaccine => {
        this.vaccines = resultVaccine;
      }
    );
    this._pacienteService.getPacient()
    .subscribe(
      resultPacient => {
        this.pacients = resultPacient;
      }
    )
  }

  ngOnInit() {
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public getPacient(): Observable<Pacient[]> {
    return this.http.get<Pacient[]>(this._baseUrl + 'api/pacient');
  }

  public getVaccine(): Observable<Vaccine[]> {
    return this.http.get<Vaccine[]>(this._baseUrl + 'api/Vaccine');
  }

  public changePacient(e): void {
    let name = e.target.value;
    let list = this.pacients.filter(x => x.name === name)[0];
  }

  public changeVaccine(e): void {
    let name = e.target.value;
    let list = this.vaccines.filter(x => x.vaccineName === name)[0];
  }

  public registrarVacina() {
    console.log('funcionando');
  }

}
