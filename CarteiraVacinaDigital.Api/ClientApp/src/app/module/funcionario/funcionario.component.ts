import { FormsModule } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

import { FuncionarioService } from './funcionario.service';
import { Office } from './../../core/model/enum/office';
import { Employee } from './../../core/model/employee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-funcionario',
  templateUrl: './funcionario.component.html',
  styleUrls: ['./funcionario.component.css']
})
export class FuncionarioComponent implements OnInit {

  employee: Employee;
  employees: Employee[];

  public activateSpinner: boolean;

  constructor(private _funcionarioService: FuncionarioService, private _router: Router) {
    this.activateSpinner = true;
    
    this._funcionarioService.getEmployee()
    .subscribe(
      employees => {
        this.employees = employees;
        this.activateSpinner = false;
      }, error => {
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
