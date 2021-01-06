import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-language-speak-offre',
  templateUrl: './language-speak-offre.component.html',
  styleUrls: ['./language-speak-offre.component.css']
})
export class LanguageSpeakOffreComponent implements OnInit {
  languageSpeak = false;

  constructor() { }

  ngOnInit(): void {
  }

  languageSpeakToggle() {
    this.languageSpeak = !this.languageSpeak;
  }

  cancelLanguageSpeak(event: boolean) {
    this.languageSpeak = event;
  }
}
