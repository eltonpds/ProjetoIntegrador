import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { State } from 'src/app/core/model/enum/stateEnum';
import { Pacient } from 'src/app/core/model/pacient';
import { PacientService } from '../pacient.service';

@Component({
  selector: 'app-pacient-form',
  templateUrl: './pacient-form.component.html',
  styleUrls: ['./pacient-form.component.css']
})
export class PacientFormComponent implements OnInit {

  pacient: Pacient;
  states = [
    {id: 1, name: 'AC'},
    {name:'AL'}, {name:'AM'},{name:'AP'},{name:'BA'}, {name:'CE'},{name:'DF'},{name:'ES'},{name:'GO'},{name:'MA'},{name:'MG'},{name:'MS'},{name:'MT'},{name:'PA'},{name:'PB'},{name:'PE'},{name:'PI'},{name:'PR'},{name:'RJ'},{name:'RN'},{name:'RO'},{name:'RR'},{name:'RS'},{name:'SC'},{name:'SE'},{name:'SP'},{name:'TO'}
  ];

  constructor(private _pacientService: PacientService, private _router: Router) {
   }

  ngOnInit() {
    this.pacient = new Pacient();
  }  

  public voltar() {
    this._router.navigate(['/paciente']);
  }

  public register() { 
    console.log('Componente funciona');
    this._pacientService.registerPacient(this.pacient)
    .subscribe(
      pacientJson => {
        this.pacient = pacientJson,
        console.log(this.pacient)
        this.voltar();
      },
      e => {
        console.log(e)
      }
    );
  }

}
