import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, ReplaySubject } from 'rxjs';
import { Language } from '../_models/language';

@Injectable({
  providedIn: 'root'
})
export class SkillService {
  urlLanguageSpeak='https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  getLanguage() {
    return this.http.get<Language[]>(this.urlLanguageSpeak + 'Skill/Language');
  }

  getProgramingLanguage() {
    return this.http.get<Language[]>(this.urlLanguageSpeak + 'Skill/ProgramingLanguage');
  }
}
