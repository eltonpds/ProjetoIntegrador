import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
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
  activateSpinner: boolean;

  constructor(private _calendarioService: CalendarioService, private _router: Router, private _toastr: ToastrService) {
    this.activateSpinner = true;
    this._calendarioService.getCalender()
    .subscribe(
      calendario => {
        this.activateSpinner = false;
        this.calendarios = calendario;
      }, error => {        
        this._toastr.error('Não foi possível carregar os dados', 'Erro de conexão');
        this.activateSpinner = false;
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
