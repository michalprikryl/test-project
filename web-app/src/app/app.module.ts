import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MainComponent } from '../components/main/main.component';
import { ContractComponent } from '../components/contract/contract.component';

@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    MainComponent,
    ContractComponent
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
