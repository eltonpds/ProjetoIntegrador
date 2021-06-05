import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FuncionarioService } from './funcionario.service';
import { FuncionarioComponent } from './funcionario.component';
import { CadastroFuncionarioComponent } from './cadastro.funcionario/cadastrofuncionario.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule
  ],
  declarations: [FuncionarioComponent, CadastroFuncionarioComponent],
  providers: [FuncionarioService]
})
export class FuncionarioModule { }
