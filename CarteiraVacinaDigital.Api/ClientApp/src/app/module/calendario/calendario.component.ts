import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Calender } from 'src/app/core/model/calender';
import { CalendarioService } from './calendario.service';

@Component({
  selector: 'app-calendario',
  templateUrl: './calendario.component.html',
  styleUrls: ['./calendario.component.css']
})
export class CalendarioComponent implements OnInit {

  calendario: Calender;
  calendarios: Calender[];

  constructor(private _calendarioService: CalendarioService, private _router: Router) {
    this._calendarioService.getCalender()
    .subscribe(
      calendario => {
        this.calendarios = calendario;
      }
    );
  }

  ngOnInit(): void {
    this.calendario = new Calender();
  }

  telaCadastro() {
    this._router.navigate(['/cadastro-calendario']);
  }

}
