import { FuncionarioComponent } from './module/funcionario/funcionario.component';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { LoginComponent } from './core/login/login.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'funcionario', component: FuncionarioComponent }
]

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {
}
