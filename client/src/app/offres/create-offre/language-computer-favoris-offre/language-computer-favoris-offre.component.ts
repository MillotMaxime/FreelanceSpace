import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-language-computer-favoris-offre',
  templateUrl: './language-computer-favoris-offre.component.html',
  styleUrls: ['./language-computer-favoris-offre.component.css']
})
export class LanguageComputerFavorisOffreComponent implements OnInit {
  @Input() newOffre: any = {};
  languageComputerFavoris = false;

  constructor() { }

  ngOnInit(): void {
    console.log(this.newOffre);
  }

  languageComputerFavorisToggle() {
    this.languageComputerFavoris = !this.languageComputerFavoris;
  }

  cancelLanguageComputerFavoris(event: boolean) {
    this.languageComputerFavoris = event;
  }
}
