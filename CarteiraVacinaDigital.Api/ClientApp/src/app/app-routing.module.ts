import { CadastroFuncionarioComponent } from './module/funcionario/cadastro.funcionario/cadastrofuncionario.component';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { LoginComponent } from './core/login/login.component';
import { HomeComponent } from './home/home.component';
import { PacienteComponent } from './module/paciente/paciente.component';
import { FuncionarioComponent } from './module/funcionario/funcionario.component';
import { VaccineComponent } from './module/vacina/vaccine.component';
import { PacientFormComponent } from './module/paciente/pacient-form/pacient-form.component';
import { RegisterVaccineComponent } from './module/register-vaccine/register-vaccine.component';
import { FormVaccineComponent } from './module/vacina/form-vaccine/form-vaccine.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: '', component: HomeComponent,
    children: [
      { path: 'registrarvacina', component: RegisterVaccineComponent },
      { path: 'funcionario', component: FuncionarioComponent },
      { path: 'cadastro-funcionario', component: CadastroFuncionarioComponent },
      { path: 'paciente', component: PacienteComponent },
      { path: 'cadastro-paciente', component: PacientFormComponent },
      { path: 'vacinas', component: VaccineComponent }, 
      { path: 'registrar-vacina', component: FormVaccineComponent }
    ]}
]

@NgModule({
  declarations: [],
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {
}
