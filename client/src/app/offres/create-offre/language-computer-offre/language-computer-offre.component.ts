import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Language } from 'src/app/_models/language';
import { LanguageService } from 'src/app/_services/language.service';

@Component({
  selector: 'app-language-computer-offre',
  templateUrl: './language-computer-offre.component.html',
  styleUrls: ['./language-computer-offre.component.css']
})
export class LanguageComputerOffreComponent implements OnInit {
  languages : Language[];
  langagesSelec: Language[];
  @Input() newOffre: any = {};
  languageComputer = false;

  constructor(private langugaeService: LanguageService) {}

  ngOnInit(): void {
    this.loadLanguageComputer();
    console.log(this.newOffre);
    console.log(this.languages);
  }

  loadLanguageComputer() {
    this.langugaeService.getComputerLanguage().subscribe(language => {
      this.languages = language;
    })
  }

  addLangageSelec(language) {
    this.langagesSelec = language;
    console.log(this.langagesSelec);
  }

  languageComputerToggle() {
    this.languageComputer = !this.languageComputer;
  }

  cancelLanguageComputer(event: boolean) {
    this.languageComputer = event;
  }
}
