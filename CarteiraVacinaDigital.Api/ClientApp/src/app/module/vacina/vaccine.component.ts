import { PacienteComponent } from './../paciente/paciente.component';
import { Pacient } from './../../core/model/pacient';
import { Component, OnInit } from '@angular/core';
import { Vaccine } from 'src/app/core/model/vaccine';
import { VaccineService } from './vaccine.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-vaccine',
  templateUrl: './vaccine.component.html',
  styleUrls: ['./vaccine.component.css']
})
export class VaccineComponent implements OnInit {

  vaccine: Vaccine;
  vaccines: Vaccine[];
  activateSpinner: boolean;

  constructor(private _vaccineService: VaccineService, private _router: Router, private _toastr: ToastrService) {
    this.activateSpinner = true;
    this._vaccineService.getVaccine()
      .subscribe(
        result => {
          this.activateSpinner = false;
          this.vaccines = result
        },
        e => {
          this._toastr.error('Não foi possível carregar os dados', 'Erro de conexão');
        }
      );
      this._router.navigate(['/vacinas']);
  }

  telaCadastro() {
    this._router.navigate(['/registrar-vacina']);
  }

   ngOnInit() {
     this.vaccine = new Vaccine();
   }
}
