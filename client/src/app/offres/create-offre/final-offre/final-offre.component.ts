import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { OfferService } from 'src/app/_services/offer.service';

@Component({
  selector: 'app-final-offre',
  templateUrl: './final-offre.component.html',
  styleUrls: ['./final-offre.component.css']
})
export class FinalOffreComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  @Input() newOffre: any = {};
  Finish: any = {};

  PrograminglanguageSelect: any = {};
  LanguageSelect: any = {};
  TypeTime: any = {};

  TextProgamingLanguage: any = {};
  TextLanguage: any = {};

  constructor(private offerService: OfferService) { }

  ngOnInit(): void {
    this.getProgamingLanguage();
    this.getLanguage();
    this.getTypeTime();
    this.Finish = false;
  }

  createOffer() 
  {
    this.newOffre.creator = JSON.parse(localStorage.getItem('user'));
    this.offerService.setOffer(this.newOffre).subscribe(reponse => {
      this.finsih();
    }, error => {
      console.log(error);
    })
  }

  getProgamingLanguage() {
    this.PrograminglanguageSelect = this.newOffre.programingLanguages;
  }

  createTextprogramingLanguage(language) {
    this.TextProgamingLanguage = language.name + " : ";
    if(language.important) {
      this.TextProgamingLanguage = this.TextProgamingLanguage + " Ce language est important et il faut ";
    } else {
      this.TextProgamingLanguage = this.TextProgamingLanguage + " Ce language n'est pas une connaissance primordiale pour votre projet mais il sera un plus si le freelanceur posséde cette connaissance avec ";
    }

    if(this.experienceUpperOne(language.experience)) {
      this.TextProgamingLanguage = this.TextProgamingLanguage + language.experience + " d'année d'expéirence."
    } else {
      this.TextProgamingLanguage = this.TextProgamingLanguage + language.experience + " d'années d'expéirences."
    }

    return this.TextProgamingLanguage;
  }

  getLanguage() {
    this.LanguageSelect = this.newOffre.language;
  }

  createLanguage(language) {
    this.TextLanguage = language.name + " : ";
    if(language.important) {
      this.TextLanguage = this.TextLanguage + " Ce language est important.";
    } else {
      this.TextLanguage = this.TextLanguage + " Ce language n'est pas une connaissance primordiale pour votre projet mais serais un plus si le freelanceur le posséde.";
    }

    return this.TextLanguage;
  }

  getTypeTime() {
    switch(this.newOffre.terms.end.TypeTime) {
      case 0:
        this.TypeTime = "Heur";
        break;
      case 1:
        this.TypeTime = "Jours";
        break;
      case 2:
        this.TypeTime = "Semaine";
        break;
      case 3:
        this.TypeTime = "Mois";
        break;
      case 4:
        this.TypeTime = "Année";
        break;
    }
  }

  finsih() {
    this.Finish = true;
  }

  cancel()
  {
    this.cancelRegister.emit(false);
  }

  experienceUpperOne(value) {
    if(value <= 1) {
      return true;
    } else {
      return false;
    }
  }
}
