import { PacienteComponent } from './../paciente/paciente.component';
import { Pacient } from './../../core/model/pacient';
import { Component, OnInit } from '@angular/core';
import { Vaccine } from 'src/app/core/model/vaccine';
import { VaccineService } from './vaccine.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-vaccine',
  templateUrl: './vaccine.component.html',
  styleUrls: ['./vaccine.component.css']
})
export class VaccineComponent implements OnInit {

  vaccine: Vaccine;
  vaccines: Vaccine[];

  constructor(private _vaccineService: VaccineService, private _router: Router) {
    this._vaccineService.getVaccine()
      .subscribe(
        result => {
          this.vaccines = result
        },
        e => {
          console.log(e);
        }
      );
  }

   ngOnInit() {
     this.vaccine = new Vaccine();
   }

   registrarVacina() {
    this._vaccineService.registerVaccine(this.vaccine)
    .subscribe(
      result => {
        this.vaccine = result
      },
      e => {
        console.log(e);
      }
    );
   }
}
