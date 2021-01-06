import { Route } from '@angular/compiler/src/core';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model: any = {}
  user: any = {}
  connected = false;
  @Output() cancelLogin = new EventEmitter();

  constructor(public accountService: AccountService, private route: Router) { }

  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('user'));
    if (this.user != null) {
      this.route.navigateByUrl('');
    } else {
      this.connected = false;
    }
  }

  login() 
  {
    this.accountService.login(this.model).subscribe(response => {
      location.reload();
    }, error => {
      console.log(error)
    })
  }

  cancel()
  {
    this.route.navigateByUrl('');
  }
}
