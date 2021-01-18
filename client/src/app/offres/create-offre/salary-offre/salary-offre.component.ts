import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-salary-offre',
  templateUrl: './salary-offre.component.html',
  styleUrls: ['./salary-offre.component.css']
})
export class SalaryOffreComponent implements OnInit {
  ponctuel = false;
  salaryOffre = false;

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

  salary: any = {};
  salaryRecurence: any = {};
  @Input() newOffre: any = {};

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

  isPonctuel() {
    if(this.ponctuel == true) {
      this.ponctuel = false;
    } else {
      this.ponctuel = true;
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

  salaryOffreToggle() {
    this.salaryOffre = !this.salaryOffre;
  }

  cancelSalaryOffre(event: boolean) {
    this.salaryOffre = event;
  }
}
