import { Component, Injectable, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { State } from 'src/app/core/model/enum/stateEnum';

import { Pacient } from './../../core/model/pacient';
import { PacientService } from './pacient.service';

@Component({
  selector: 'app-paciente',
  templateUrl: './paciente.component.html',
  styleUrls: ['./paciente.component.css']
})
export class PacienteComponent implements OnInit {

  pacient: Pacient;
  pacients: Pacient[];

  activateSpinner: boolean;
  
  constructor(private _pacienteService: PacientService, private _router: Router) {
    this.activateSpinner = true;
    this._pacienteService.getPacient()
      .subscribe(
        result => {
          this.pacients = result
          this.activateSpinner = false;
        },
        e => {
          this.activateSpinner = false;
        }
      );
  }

  ngOnInit(): void {
    this.pacient = new Pacient();
  }

  telaCadastro() {
    this._router.navigate(['/cadastro-paciente']);
  }
}
