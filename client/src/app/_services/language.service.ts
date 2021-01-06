import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, ReplaySubject } from 'rxjs';
import { Language } from '../_models/language';

@Injectable({
  providedIn: 'root'
})
export class LanguageService {
  urlLanguageSpeak='https://localhost:5001/api/';

  private languageSpeak = new ReplaySubject<Language>(10);
  languageSpeak$ = this.languageSpeak.asObservable();

  constructor(private http: HttpClient) { }

  getLanguageSpeak() {
    return this.http.get<Language[]>(this.urlLanguageSpeak + 'Speak');
  }

  getComputerLanguage() {
    return this.http.get<Language[]>(this.urlLanguageSpeak + 'ComputerLanguage');
  }
}
