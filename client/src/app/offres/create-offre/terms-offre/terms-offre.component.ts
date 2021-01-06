import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-terms-offre',
  templateUrl: './terms-offre.component.html',
  styleUrls: ['./terms-offre.component.css']
})
export class TermsOffreComponent implements OnInit {
  termsOffre = false;
  terms: any = {};
  termsEnd: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  penaltyOffreToggle() {
    this.termsOffre = !this.termsOffre;
  }

  cancelPenaltyOffre(event: boolean) {
    this.termsOffre = event;
  }
}
