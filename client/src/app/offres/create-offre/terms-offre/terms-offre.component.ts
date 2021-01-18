import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-terms-offre',
  templateUrl: './terms-offre.component.html',
  styleUrls: ['./terms-offre.component.css']
})
export class TermsOffreComponent implements OnInit {
  termsOffre = false;
  deadLine = true;

  ponctuelHourMontant = false;
  ponctuelDayMontant = false;
  ponctuelWeekMontant = false;
  ponctuelMonthMontant = false;
  hourMontant : number;
  dayMontant : number;
  weekMontant : number;
  monthMontant : number;

  recurence : String[];
  valueRecu : String;


  terms: any = {};
  termsEnd: any = {};

  constructor() { }

  ngOnInit(): void {
    this.createRecurence();
  }

  ponctuelMontant() {
    console.log(this.valueRecu);
    switch(this.valueRecu) {
      case "Heur": 
        this.ponctuelHourMontant = true;
        this.ponctuelDayMontant = false;
        this.ponctuelWeekMontant = false;
        this.ponctuelMonthMontant = false;
        break;
      case "Jour":
        this.ponctuelDayMontant = true;
        this.ponctuelHourMontant = false;
        this.ponctuelWeekMontant = false;
        this.ponctuelMonthMontant = false;
        break;
      case "Semaine":
        this.ponctuelWeekMontant = true;
        this.ponctuelHourMontant = false;
        this.ponctuelDayMontant = false;
        this.ponctuelMonthMontant = false;
        break;
      case "Mois":
        this.ponctuelMonthMontant = true;
        this.ponctuelHourMontant = false;
        this.ponctuelDayMontant = false;
        this.ponctuelWeekMontant = false;
        break;
      case null:
        this.ponctuelHourMontant = false;
        this.ponctuelDayMontant = false;
        this.ponctuelWeekMontant = false;
        this.ponctuelMonthMontant = false;
        break;
    }
  }

  createRecurence() {
    const recurence = [];
    recurence.push("Heur");
    recurence.push("Jour");
    recurence.push("Semaine");
    recurence.push("Mois");
    this.recurence = recurence;
  }

  noDaedLine() {
    if(this.deadLine) {
      this.deadLine = false;
    } else {
      this.deadLine = true;
    }
  }

  penaltyOffreToggle() {
    this.termsOffre = !this.termsOffre;
  }

  cancelPenaltyOffre(event: boolean) {
    this.termsOffre = event;
  }
}
