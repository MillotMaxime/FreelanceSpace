import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { OffresListComponent } from './offres/offres-list/offres-list.component';
import { OffreDetailComponent } from './offres/offre-detail/offre-detail.component';
import { CreateOffreComponent } from './offres/create-offre/create-offre.component';
import { OffreComponent } from './offres/offre/offre.component';
import { CompteDetailComponent } from './compte/compte-detail/compte-detail.component';
import { MessagesListComponent } from './compte/messages/messages-list/messages-list.component';
import { MessagesDetailComponent } from './compte/messages/messages-detail/messages-detail.component';
import { ConvertationComponent } from './compte/messages/convertation/convertation.component';
import { CurrentEmployementComponent } from './compte/emploi/current-employement/current-employement.component';
import { PaiementInProgressComponent } from './compte/emploi/paiement-in-progress/paiement-in-progress.component';
import { PaiementComponent } from './compte/emploi/paiement/paiement.component';
import { ContactUsComponent } from './contact-us/contact-us/contact-us.component';
import { PremiumComponent } from './premium/premium/premium.component';
import { LoginComponent } from './login/login.component';
import { EmployementAchieveDetailComponent } from './compte/emploi/employementAchieve/employement-achieve-detail/employement-achieve-detail.component';
import { NextEmployementListComponent } from './compte/emploi/nextEmployement/next-employement-list/next-employement-list.component';
import { NextEmployementDetailComponent } from './compte/emploi/nextEmployement/next-employement-detail/next-employement-detail.component';
import { EmployementComponent } from './compte/emploi/employement/employement.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    OffresListComponent,
    OffreDetailComponent,
    CreateOffreComponent,
    OffreComponent,
    CompteDetailComponent,
    MessagesListComponent,
    MessagesDetailComponent,
    ConvertationComponent,
    CurrentEmployementComponent,
    PaiementInProgressComponent,
    PaiementComponent,
    ContactUsComponent,
    PremiumComponent,
    LoginComponent,
    EmployementAchieveDetailComponent,
    NextEmployementListComponent,
    NextEmployementDetailComponent,
    EmployementComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    BsDropdownModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
