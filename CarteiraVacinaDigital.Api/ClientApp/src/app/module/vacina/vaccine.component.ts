import { PacienteComponent } from './../paciente/paciente.component';
import { Pacient } from './../../core/model/pacient';
import { Component, OnInit } from '@angular/core';
import { Vaccine } from 'src/app/core/model/vaccine';


@Component({
  selector: 'app-vaccine',
  templateUrl: './vaccine.component.html',
  styleUrls: ['./vaccine.component.css']
})
export class VaccineComponent implements OnInit {

  vaccines: Vaccine[];
  pacientes: Pacient[];
  pacienteSelecionado: Pacient[];
  vacinaSelecionada: Vaccine[];

  constructor(paciente: PacienteComponent) {
    this.vaccines = [
      {name: 'H1N1'},
      {name: 'Varíola'},
      {name: 'Sarampo'},
      {name: 'Febre Amarela'},
      {name: 'Tetâno'},
    ];

    this.pacientes = paciente.carregarPacientes();
   }

   ngOnInit() {
   }
}
