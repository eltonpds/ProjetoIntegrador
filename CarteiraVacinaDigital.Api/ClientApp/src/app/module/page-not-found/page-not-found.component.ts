import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Pacient } from 'src/app/core/model/pacient';
import { Vaccine } from 'src/app/core/model/vaccine';
import { PacientService } from '../paciente/pacient.service';
import { VaccineService } from '../vacina/vaccine.service';

@Component({
  selector: 'app-page-not-found',
  templateUrl: './page-not-found.component.html',
  styleUrls: ['./page-not-found.component.css']
})
export class PageNotFoundComponent implements OnInit {

  constructor() {
  }

  ngOnInit() {
  }

}
