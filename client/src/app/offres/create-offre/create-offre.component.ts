
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ReplaySubject } from 'rxjs';
import { Language } from 'src/app/_models/language';
import { AccountService } from 'src/app/_services/account.service';
import { SkillService } from 'src/app/_services/skill.service';

@Component({
  selector: 'app-create-offre',
  templateUrl: './create-offre.component.html',
  styleUrls: ['./create-offre.component.css']
})
export class CreateOffreComponent implements OnInit {
  descriptif = false;
  name: string;
  description: string;
  offre: any = {};
  salary: any = {};
  salaryRecurence: any = {};
  penalty: any = {};
  penaltyRecurence: any = {};
  terms: any = {};
  termsEnd: any = {};
  speak: any = {};
  allLanguageSpeak:  any = {};
  allComputerLanguage: any = {};

  constructor(private accountService: AccountService, private languageService: SkillService, private route: Router) {}

  ngOnInit(): void {
    this.salary.recurence = this.salaryRecurence;
    this.offre.salary = this.salary;
    this.penalty.recurence = this.penaltyRecurence;
    this.offre.penalty = this.penalty;
    this.terms.End = this.termsEnd;
    this.offre.terms = this.terms;
  }

  cancel()
  {
    this.route.navigateByUrl('');
  }

  descriptifToggle() {
    this.offre.name = this.name;
    this.offre.description = this.description;
    this.descriptif = !this.descriptif;
  }

  cancelDescriptif(event: boolean) {
    this.descriptif = event;
  }
}
