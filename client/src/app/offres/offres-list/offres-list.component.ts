import { Component, OnInit } from '@angular/core';
import { OfferService } from 'src/app/_services/offer.service';

@Component({
  selector: 'app-offres-list',
  templateUrl: './offres-list.component.html',
  styleUrls: ['./offres-list.component.css']
})
export class OffresListComponent implements OnInit {
  offres: any = {}
  programingLanguageOffer: any = {}

  constructor(public offerService: OfferService) { }

  ngOnInit(): void {
    this.getOffer();
    this.getProgramingLanguageOffer();
  }

  getOffer() {
    this.offres = this.offerService.getOffer().subscribe((element) => {
      this.offres = element;
    })
  }

  getProgramingLanguageOffer() {
    this.programingLanguageOffer = this.offerService.getProgramingLanguageOffer().subscribe((element) => {
      this.programingLanguageOffer = element;
      console.log(this.programingLanguageOffer);
    })
  }
}
