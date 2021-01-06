import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  model: any = {}
  registerMode = false;
  users: any;

  constructor(private http: HttpClient, public accountService: AccountService) {

  }

  ngOnInit(): void {
     this.getUser();
     console.log(this.users);
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  getUser() {
    this.http.get('https://localhost:5001/api/users').subscribe(
      users => {this.users = users}
     );
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }
}
