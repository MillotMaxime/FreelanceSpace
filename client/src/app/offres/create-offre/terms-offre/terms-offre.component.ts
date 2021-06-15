import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-terms-offre',
  templateUrl: './terms-offre.component.html',
  styleUrls: ['./terms-offre.component.css']
})
export class TermsOffreComponent implements OnInit {
  @Input() newOffre: any = {};
  termsOffre = false;

  typeTimes : String[];
  typeTimeSelect : String;

  terms: any = {};
  salary: any = {};
  penalty: any = {};
  penaltyTauxHorraire: any = {};
  termsEnd: any = {};

  constructor() { }

  ngOnInit(): void {
    this.createRecurence();
  }

  createRecurence() {
    const recurence = [];
    recurence.push("Heur(s)");
    recurence.push("Jour(s)");
    recurence.push("Semaine(s)");
    recurence.push("Mois");
    recurence.push("Année(s)");
    this.typeTimes = recurence;
  }

  ponctuelMontant() {
    switch(this.typeTimeSelect) {
      case "Heur(s)":
        this.termsEnd.TypeTime = 0;
        break;
      case "Jour(s)":
        this.termsEnd.TypeTime = 1;
        break;
      case "Semaine(s)":
        this.termsEnd.TypeTime = 2;
        break;
      case "Mois":
        this.termsEnd.TypeTime = 3;
        break;
      case "Année(s)":
        this.termsEnd.TypeTime = 4;
        break;
      case null:
        this.termsEnd.TypeTime = null;
        break;
    }
  }

  penaltyOffreToggle() {
    this.penaltyTauxHorraire.typeTaux = 0;
    this.penalty = this.penaltyTauxHorraire;

    this.terms.end = this.termsEnd;

    this.newOffre.penalty = this.penalty;
    this.newOffre.salary = this.salary;
    this.newOffre.terms = this.terms;

    this.termsOffre = !this.termsOffre;
  }

  cancelPenaltyOffre(event: boolean) {
    this.termsOffre = event;
  }
}
