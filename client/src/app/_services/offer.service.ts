import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OfferService {
  urlLanguageSpeak='https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  getOffer() {
    return this.http.get(this.urlLanguageSpeak + 'Offers');
  }

  getProgramingLanguageOffer() {
    return this.http.get(this.urlLanguageSpeak + 'Offers/OfferProgramingLanguage');
  }

  setOffer(model: any) {
    return this.http.post(this.urlLanguageSpeak + 'Offers', model);
  }
}
