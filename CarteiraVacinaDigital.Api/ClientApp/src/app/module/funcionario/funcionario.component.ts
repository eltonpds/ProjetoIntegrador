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

  constructor(private _funcionarioService: FuncionarioService, private _router: Router) {
    this._funcionarioService.getEmployee()
    .subscribe(
      employees => {
        this.employees = employees;
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
