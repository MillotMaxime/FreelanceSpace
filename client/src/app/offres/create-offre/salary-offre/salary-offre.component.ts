import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-salary-offre',
  templateUrl: './salary-offre.component.html',
  styleUrls: ['./salary-offre.component.css']
})
export class SalaryOffreComponent implements OnInit {
  salaryOffre = false;
  salary: any = {};
  salaryRecurence: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  salaryOffreToggle() {
    this.salaryOffre = !this.salaryOffre;
  }

  cancelSalaryOffre(event: boolean) {
    this.salaryOffre = event;
  }
}
