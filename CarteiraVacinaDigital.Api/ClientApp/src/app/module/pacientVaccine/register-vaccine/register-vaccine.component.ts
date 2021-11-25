import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';

import { Pacient } from 'src/app/core/model/pacient';
import { PacientVaccine } from 'src/app/core/model/pacientVaccine';
import { Vaccine } from 'src/app/core/model/vaccine';
import { PacientService } from '../../paciente/pacient.service';
import { VaccineService } from '../../vaccine/vaccine.service';
import { PacientVaccineService } from '../pacientVaccine.service';

@Component({
  selector: 'app-register-vaccine',
  templateUrl: './register-vaccine.component.html',
  styleUrls: ['./register-vaccine.component.css']
})
export class RegisterVaccineComponent implements OnInit {

  pacientVaccine: PacientVaccine;
  private _baseUrl: string;
  pacients: Pacient[];
  pacient: Pacient;
  vaccines: Vaccine[];
  vaccine: Vaccine;


  activateSpinner: boolean;

  constructor(private _pacientVaccineService: PacientVaccineService, private _vaccineService: VaccineService, private _pacienteService: PacientService, private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private _router: Router, private _toastr: ToastrService) { 
    this.vaccine = new Vaccine();

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
    this.pacientVaccine = new PacientVaccine();
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
    let list = this.pacients.filter(x => x.Name === name)[0];
    this.pacient = list;
  }

  public changeVaccine(e): void {
    let name = e.target.value;
    let list = this.vaccines.filter(x => x.VaccineName === name)[0];
    this.vaccine = list;
  }

  public voltar() {
    this._router.navigate(['/listar-pacientes-vacinadas']);
  }

  public registrarVacina() {
    this.activateSpinner = true;
    this.pacientVaccine.PacientId = this.pacient.Id;
    this.pacientVaccine.VaccineId = this.vaccine.Id;
    this.pacientVaccine.UniqueDose = this.vaccine.UniqueDose;

    this._pacientVaccineService.registrarPacienteVacinado(this.pacientVaccine).subscribe(
      result => {
        this.activateSpinner = false;
        this.pacientVaccine = result;
        this._toastr.success('Paciente vacinado', 'Sucesso');        
        this.voltar();
      },
      e => {
        this._toastr.error(e.error);
        this.activateSpinner = false;
      }
      );
  }

}
