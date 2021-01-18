import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CompteDetailComponent } from './compte/compte-detail/compte-detail.component';
import { CurrentEmployementComponent } from './compte/emploi/current-employement/current-employement.component';
import { EmployementComponent } from './compte/emploi/employement/employement.component';
import { EmployementAchieveDetailComponent } from './compte/emploi/employementAchieve/employement-achieve-detail/employement-achieve-detail.component';
import { EmployementAchieveListComponent } from './compte/emploi/employementAchieve/employement-achieve-list/employement-achieve-list.component';
import { NextEmployementDetailComponent } from './compte/emploi/nextEmployement/next-employement-detail/next-employement-detail.component';
import { NextEmployementListComponent } from './compte/emploi/nextEmployement/next-employement-list/next-employement-list.component';
import { PaiementInProgressComponent } from './compte/emploi/paiement-in-progress/paiement-in-progress.component';
import { PaiementComponent } from './compte/emploi/paiement/paiement.component';
import { ConvertationComponent } from './compte/messages/convertation/convertation.component';
import { ContactUsComponent } from './contact-us/contact-us/contact-us.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { CreateOffreComponent } from './offres/create-offre/create-offre.component';
import { OffreDetailComponent } from './offres/offre-detail/offre-detail.component';
import { OffreComponent } from './offres/offre/offre.component';
import { OffresListComponent } from './offres/offres-list/offres-list.component';
import { PremiumComponent } from './premium/premium/premium.component';

const routes: Routes = [
  {path: '', component: HomeComponent,},
  {path: 'offre', component: OffreComponent},
  {path: 'offres', component: OffresListComponent},
  {path: 'offreCreate', component: CreateOffreComponent},
  {path: 'offre/:id', component: OffreDetailComponent},
  {path: 'premium', component: PremiumComponent},
  {path: 'myCompte', component: CompteDetailComponent},
  {path: 'employement', component: EmployementComponent},
  {path: 'currentEmployement', component: CurrentEmployementComponent},
  {path: 'employementAchieveList', component: EmployementAchieveListComponent},
  {path: 'employementAchieve/:id', component: EmployementAchieveDetailComponent},
  {path: 'nextEmployement', component: NextEmployementListComponent},
  {path: 'nextEmployement/:id', component: NextEmployementDetailComponent},
  {path: 'paiement', component: PaiementComponent},
  {path: 'paiementInProgress', component: PaiementInProgressComponent},
  {path: 'messages', component: ConvertationComponent},
  {path: 'login', component: LoginComponent},
  {path: 'contactUs', component: ContactUsComponent},
  {path: '**', component: HomeComponent, pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    onSameUrlNavigation: 'reload',
    relativeLinkResolution: 'legacy'
})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
