import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './/app-routing.module';
import { CommonModule } from '@angular/common';

import { NgxMaskModule } from 'ngx-mask';

import { PacientModule } from './module/paciente/pacient.module';
import { FuncionarioModule } from './module/funcionario/funcionario.module';
import { HomeComponent } from './home/home.component';
import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { AsideComponent } from './layout/aside/aside.component';
import { VacinaModule } from './module/vacina/vacina.module';
import { LoginComponent } from './core/login/login.component';
import { RegisterVaccineComponent } from './module/register-vaccine/register-vaccine.component';
import { CalendarioModule } from './module/calendario/calendario.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    AsideComponent,
    LoginComponent,
    RegisterVaccineComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    CommonModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot({
      dropSpecialCharacters: false
    }),
    FuncionarioModule,
    PacientModule,
    VacinaModule,
    CalendarioModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
