import { Component, Input, OnInit } from '@angular/core';
import { Language } from 'src/app/_models/language';
import { SkillService } from 'src/app/_services/skill.service';

@Component({
  selector: 'app-language-speak-offre',
  templateUrl: './language-speak-offre.component.html',
  styleUrls: ['./language-speak-offre.component.css']
})
export class LanguageSpeakOffreComponent implements OnInit {
  languages : Language[];
  languageSpeak = false;
  @Input() newOffre: any = {};

  constructor(private langugaeService: SkillService) { }

  ngOnInit(): void {
    this.loadLanguageSpeak();
    this.newOffre.language = null;
  }

  loadLanguageSpeak() {
    this.langugaeService.getLanguageSpeak().subscribe(language => {
      const languagesSelect = language;
      languagesSelect.forEach(element => {
        element.check = false;
      });
      this.languages = languagesSelect;
    });
  }

  checkLanguage(language) {
    language.check = true;
  }

  addLangageSelec(language) {
    this.checkLanguage(language);
    if (this.newOffre.language == undefined) {
      const languagesSelect = [];
      languagesSelect.push(language);
      this.newOffre.language = languagesSelect;
      this.newOffre.language[0].important = false;
    } else {
      this.newOffre.language.push(language);
      const numberIndex = this.newOffre.language.indexOf(language);
      this.newOffre.language[numberIndex].important = false;
    }
  }

  isImportant(language) {
    const numberIndex = this.newOffre.language.indexOf(language);
    if (this.newOffre.language[numberIndex].important == undefined 
      || this.newOffre.language[numberIndex].important == false) {
        this.newOffre.language[numberIndex].important = true;
    } else {
      this.newOffre.language[numberIndex].important = false;
    }
  }

  languageSpeakToggle() {
    this.languageSpeak = !this.languageSpeak;
  }

  cancelLanguageSpeak(event: boolean) {
    this.languageSpeak = event;
  }
}
