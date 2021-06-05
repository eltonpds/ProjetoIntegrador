import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
<<<<<<< HEAD
import { RouterModule } from '@angular/router';
=======
import { AppRoutingModule } from './/app-routing.module';
import { CommonModule } from '@angular/common';
>>>>>>> desenvolvimento

import { PacientModule } from './module/paciente/pacient.module';
import { FuncionarioModule } from './module/funcionario/funcionario.module';
import { HomeComponent } from './home/home.component';
import { AppComponent } from './app.component';
<<<<<<< HEAD
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
=======
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { AsideComponent } from './layout/aside/aside.component';
import { VacinaModule } from './module/vacina/vacina.module';
import { LoginComponent } from './core/login/login.component';
>>>>>>> desenvolvimento

@NgModule({
  declarations: [
    AppComponent,
<<<<<<< HEAD
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent
=======
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    AsideComponent,
    LoginComponent
>>>>>>> desenvolvimento
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    CommonModule,
    HttpClientModule,
    FormsModule,
<<<<<<< HEAD
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
=======
    AppRoutingModule,
    FuncionarioModule,
    PacientModule,
    ReactiveFormsModule,
    VacinaModule
>>>>>>> desenvolvimento
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
