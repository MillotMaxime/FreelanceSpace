import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl='https://localhost:5001/api/';
  paramateBusinessUrl='?email=';

  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();
  users: any = {};

  constructor(private http: HttpClient) { }

  login(model : any) 
  {
    return this.http.post(this.baseUrl + 'account/login', model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {
          this.setBuisness(user);
          this.saveLocalStorage(user);
          this.setCurrentUser(user);
        }
      })
    );
  }

  register(model: any) {
    return this.http.post(this.baseUrl + 'account/register', model).pipe(
      map((user: User) => {
        if (user) {
          this.setBuisness(user);
          this.saveLocalStorage(user);
          this.setCurrentUser(user);
        }
      })
    );
  }

  setBuisness(user: User)
  {
    this.http.get(this.baseUrl + 'users/isBusiness' + this.paramateBusinessUrl + user.email).subscribe(users =>
      {
        if(users != null) {
          user.isBuisness = true;
        } else {
          user.isBuisness = false;
        }
      });

      return user;
  }

  saveLocalStorage(user: User) {
    localStorage.setItem('user', JSON.stringify(user));
  }

  setCurrentUser(user: User) {
    this.currentUserSource.next(user);
  }

  logout() {
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
  }
}
