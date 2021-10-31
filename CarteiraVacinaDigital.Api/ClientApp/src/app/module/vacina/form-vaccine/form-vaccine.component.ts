import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Vaccine } from 'src/app/core/model/vaccine';
import { VaccineService } from '../vaccine.service';

@Component({
  selector: 'app-form-vaccine',
  templateUrl: './form-vaccine.component.html',
  styleUrls: ['./form-vaccine.component.css']
})
export class FormVaccineComponent implements OnInit {

  vaccine: Vaccine;

  constructor(private _vaccineService: VaccineService, private _router: Router) { }

  ngOnInit() {
    this.vaccine = new Vaccine();
  }

  registrarVacina() {
    this._vaccineService.registerVaccine(this.vaccine)
    .subscribe(
      result => {
        this.vaccine = result
        this.voltar();
      },
      e => {
        console.log(e);
      }
    );
   }
   
  public voltar() {
    this._router.navigate(['/vacinas']);
  }
}
