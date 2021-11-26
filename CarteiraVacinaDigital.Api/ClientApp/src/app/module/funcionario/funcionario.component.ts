import { FormsModule } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

import { FuncionarioService } from './funcionario.service';
import { Office, OfficeEnum, OfficeLabelMapping } from './../../core/model/enum/office';
import { Employee } from './../../core/model/employee';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { StateEnum } from 'src/app/core/model/enum/stateEnum';

@Component({
  selector: 'app-funcionario',
  templateUrl: './funcionario.component.html',
  styleUrls: ['./funcionario.component.css']
})
export class FuncionarioComponent implements OnInit {

  employee: Employee;
  employees: Employee[];
  OfficeEnum = OfficeEnum;

  public activateSpinner: boolean;

  constructor(private _funcionarioService: FuncionarioService, private _router: Router, private _toastr: ToastrService) {
    this.activateSpinner = true;
    
    this._funcionarioService.getEmployee()
    .subscribe(
      employees => {
        this.employees = employees;
        this.activateSpinner = false;
      }, error => {
        this._toastr.error('Não foi possível carregar os dados', 'Erro de conexão');
        this.activateSpinner = false;
      }
    );
  }

  ngOnInit(): void {
    this.employee = new Employee();
  }

  telaCadastro() {
    this._router.navigate(['/cadastro-funcionario']);
  }
}
