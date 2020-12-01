import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { error } from 'protractor';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}

  constructor(private http: HttpClient, public accountService: AccountService, private route: Router) { }

  ngOnInit(): void {}

  login()
  {
    this.route.navigateByUrl('/login');
  }

  logout() 
  {
    this.accountService.logout();
  }

}
