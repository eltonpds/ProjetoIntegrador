import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './/app-routing.module';
import { CommonModule } from '@angular/common';

import { NgxMaskModule } from 'ngx-mask';
import { ToastrModule } from 'ngx-toastr';

import { PacientModule } from './module/paciente/pacient.module';
import { FuncionarioModule } from './module/funcionario/funcionario.module';
import { HomeComponent } from './home/home.component';
import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { AsideComponent } from './layout/aside/aside.component';
import { VaccineModule } from './module/vaccine/vaccine.module';
import { LoginComponent } from './core/login/login.component';
import { RegisterVaccineComponent } from './module/pacientVaccine/register-vaccine/register-vaccine.component';
import { CalendarioModule } from './module/calendario/calendario.module';
import { PacientVaccineModule } from './module/pacientVaccine/pacientVaccine.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    AsideComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    CommonModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot({
      dropSpecialCharacters: false
    }),
    ToastrModule.forRoot(),
    FuncionarioModule,
    PacientModule,
    VaccineModule,
    CalendarioModule,
    PacientVaccineModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
