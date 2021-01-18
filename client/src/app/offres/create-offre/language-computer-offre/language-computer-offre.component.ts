import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { FormArray, FormGroup, FormsModule } from '@angular/forms';
import { exists } from 'fs';
import { Language } from 'src/app/_models/language';
import { LanguageService } from 'src/app/_services/language.service';

@Component({
  selector: 'app-language-computer-offre',
  templateUrl: './language-computer-offre.component.html',
  styleUrls: ['./language-computer-offre.component.css']
})
export class LanguageComputerOffreComponent implements OnInit {
  languages : Language[];
  @Input() newOffre: any = {};
  languageComputer = false;
  experience: number[];

  constructor(private langugaeService: LanguageService) {}

  ngOnInit(): void {
    this.loadLanguageComputer();
    this.newOffre.computerLanguage = null;
    this.experience = [];
  }

  loadLanguageComputer() {
    this.langugaeService.getComputerLanguage().subscribe(language => {
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
    this.checkLanguage(language)
    if (this.newOffre.computerLanguage == undefined) {
      const languagesSelect = [];
      languagesSelect.push(language);
      this.newOffre.computerLanguage = languagesSelect;
      this.newOffre.computerLanguage[0].important = false;
    } else {
      this.newOffre.computerLanguage.push(language);
      const numberIndex = this.newOffre.computerLanguage.indexOf(language);
      this.newOffre.computerLanguage[numberIndex].important = false;
    }
  }

  isImportant(language) {
    const numberIndex = this.newOffre.computerLanguage.indexOf(language);
    if (this.newOffre.computerLanguage[numberIndex].important == undefined 
      || this.newOffre.computerLanguage[numberIndex].important == false) {
      this.newOffre.computerLanguage[numberIndex].important = true;
    } else {
      this.newOffre.computerLanguage[numberIndex].important = false;
    }
  }
  
  yearExperience(language, experience) {
    const numberIndex = this.newOffre.computerLanguage.indexOf(language);
    console.log(experience);
    this.newOffre.computerLanguage[numberIndex].experience = experience;
  }

  languageComputerToggle() {
    this.languageComputer = !this.languageComputer;
    console.log(this.newOffre);
  }

  cancelLanguageComputer(event: boolean) {
    this.languageComputer = event;
  }
}
