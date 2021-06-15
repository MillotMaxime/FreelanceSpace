import { Component, Input, OnInit } from '@angular/core';
import { Language } from 'src/app/_models/language';
import { SkillService } from 'src/app/_services/skill.service';

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

  constructor(private langugaeService: SkillService) {}

  ngOnInit(): void {
    this.loadLanguageComputer();
    this.newOffre.programingLanguages = null;
    this.experience = [];
  }

  loadLanguageComputer() {
    this.langugaeService.getProgramingLanguage().subscribe(language => {
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

  addOrRemoveLangageSelec(language) {
    this.checkLanguage(language)
    if (this.newOffre.programingLanguages == undefined) {
      const languagesSelect = [];
      languagesSelect.push(language);
      this.newOffre.programingLanguages = languagesSelect;
      this.newOffre.programingLanguages[0].important = false;
      this.newOffre.programingLanguages[0].experience = 0;
    } else {
      let newLanguage = true;

      this.newOffre.programingLanguages.forEach(languages => {
        if (languages.name == language.name) {
          const numberIndex = this.newOffre.programingLanguages.indexOf(languages);
          delete  this.newOffre.programingLanguages[numberIndex];
          newLanguage = false;
          language.check = false;
        }
      });
      
      if(newLanguage) {
        this.addLangageSelec(language);
      }
    }
  }

  addLangageSelec(language) {
    this.newOffre.programingLanguages.push(language);
    const numberIndex = this.newOffre.programingLanguages.indexOf(language);
    this.newOffre.programingLanguages[numberIndex].important = false;
    this.newOffre.programingLanguages[numberIndex].experience = 0;
  }

  isImportant(language) {
    const numberIndex = this.newOffre.programingLanguages.indexOf(language);
    if (this.newOffre.programingLanguages[numberIndex].important == undefined 
      || this.newOffre.programingLanguages[numberIndex].important == false) {
      this.newOffre.programingLanguages[numberIndex].important = true;
    } else {
      this.newOffre.programingLanguages[numberIndex].important = false;
    }
  }
  
  yearExperience(language, experience) {
    const numberIndex = this.newOffre.programingLanguages.indexOf(language);
    this.newOffre.programingLanguages[numberIndex].experience = experience;
  }

  languageComputerToggle() {
    this.languageComputer = !this.languageComputer;
  }

  cancelLanguageComputer(event: boolean) {
    this.languageComputer = event;
  }
}
