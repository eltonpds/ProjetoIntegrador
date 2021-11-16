import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';

import { Vaccine } from 'src/app/core/model/vaccine';
import { VaccineService } from '../vaccine.service';

@Component({
  selector: 'app-form-vaccine',
  templateUrl: './form-vaccine.component.html',
  styleUrls: ['./form-vaccine.component.css']
})
export class FormVaccineComponent implements OnInit {

  vaccine: Vaccine;
  activateSpinner: boolean;

  constructor(private _vaccineService: VaccineService, private _router: Router, private _toastr: ToastrService) { }

  ngOnInit() {
    this.vaccine = new Vaccine();
  }

  registrarVacina() {
    this.activateSpinner = true;
    this._vaccineService.registerVaccine(this.vaccine)
    .subscribe(
      result => {
        this.activateSpinner = false;
        this.vaccine = result;
        this._toastr.success('Vacina cadastrada', 'Sucesso');
        this.voltar();        
      },
      e => {
        this._toastr.error('Não foi possível concluir a solicitação');
        this.activateSpinner = false;
      }
      );
   }
   
  public voltar() {
    this._router.navigate(['/vacinas']);
  }
}
