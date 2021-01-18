import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './home/register/register.component';
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
import { LanguageComputerOffreComponent } from './offres/create-offre/language-computer-offre/language-computer-offre.component';
import { LanguageSpeakOffreComponent } from './offres/create-offre/language-speak-offre/language-speak-offre.component';
import { SalaryOffreComponent } from './offres/create-offre/salary-offre/salary-offre.component';
import { PenaltyOffreComponent } from './offres/create-offre/penalty-offre/penalty-offre.component';
import { TermsOffreComponent } from './offres/create-offre/terms-offre/terms-offre.component';
import { MatCheckboxModule } from "@angular/material/Checkbox";
import { MatButtonToggleModule } from '@angular/material/button-toggle';

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
    EmployementComponent,
    LanguageComputerOffreComponent,
    LanguageSpeakOffreComponent,
    SalaryOffreComponent,
    PenaltyOffreComponent,
    TermsOffreComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatCheckboxModule,
    MatButtonToggleModule,
    FormsModule,
    ReactiveFormsModule,
    BsDropdownModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
