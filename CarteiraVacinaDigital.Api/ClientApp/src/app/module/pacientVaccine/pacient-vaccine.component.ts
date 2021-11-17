import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';

import { PacientVaccine } from 'src/app/core/model/pacientVaccine';
import { PacientVaccineService } from './pacientVaccine.service';

@Component({
  selector: 'app-pacient-vaccine',
  templateUrl: './pacient-vaccine.component.html',
  styleUrls: ['./pacient-vaccine.component.css']
})
export class PacientVaccineComponent implements OnInit {

  pacientVaccine: PacientVaccine[];
  activateSpinner: boolean;

  constructor(private _pacienteVaccineService: PacientVaccineService, private _router: Router, private _toastr: ToastrService) {
    this.activateSpinner = true;
    this._pacienteVaccineService.getPacientsVaccinated()
    .subscribe(
      data => {
        this.activateSpinner = false;
        this.pacientVaccine = data;
      }
    );
   }

  ngOnInit() {
  }

  telaVacinarPaciente() {
    this._router.navigate(['/registrarvacina']);
  }

}
