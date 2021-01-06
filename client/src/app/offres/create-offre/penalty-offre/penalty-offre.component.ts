import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-penalty-offre',
  templateUrl: './penalty-offre.component.html',
  styleUrls: ['./penalty-offre.component.css']
})
export class PenaltyOffreComponent implements OnInit {
  penaltyOffre = false;
  penalty: any = {};
  penaltyRecurence: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  penaltyOffreToggle() {
    this.penaltyOffre = !this.penaltyOffre;
  }

  cancelPenaltyOffre(event: boolean) {
    this.penaltyOffre = event;
  }
}
