import { VaccineComponent } from './../vacina/vaccine.component';
import { Pacient } from './../../core/model/pacient';
import { Component, Injectable, OnInit } from '@angular/core';

@Component({
  selector: 'app-paciente',
  templateUrl: './paciente.component.html',
  styleUrls: ['./paciente.component.css']
})
@Injectable({
  providedIn: 'root'
})
export class PacienteComponent implements OnInit {

  pacientes: Pacient[];
  constructor() {
    this.pacientes = [
      {id: 1, name: 'Gabriel'},
      {id: 2, name: 'Kelly'},
      {id: 3, name: 'Josy'},
      {id: 4, name: 'Vitória'},
      {id: 5, name: 'Jeová'},
    ]
  }

  ngOnInit() {
  }
  carregarPacientes() {
    return this.pacientes;
  }
}
