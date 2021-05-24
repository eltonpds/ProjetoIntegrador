import { Component, OnInit } from '@angular/core';

import { Funcao } from './funcao';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  ngOnInit() {

  }

  funcao: Funcao[] = [
    { id: 1, name: 'Funcionário', url: 'funcionario' },
    { id: 2, name: 'Agendamento', url: 'agendamento' },
    { id: 3, name: 'Histórico', url: 'historico' },
    { id: 4, name: 'Registrar Vacina', url: 'registrarvacina' }
  ];
}
