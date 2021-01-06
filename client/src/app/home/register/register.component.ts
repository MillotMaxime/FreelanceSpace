import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  //@Input() usersFromHomeComponent: any;
  @Output() cancelRegister = new EventEmitter();
  model: any = {};
  business: any;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
    this.business = false;
  }

  register() 
  {
    this.accountService.register(this.model).subscribe(reponse => {
      this.cancel();
    }, error => {
      console.log(error);
    })
  }

  cancel()
  {
    this.cancelRegister.emit(false);
  }

  isBusiness()
  {
    switch (this.business) {
      case false :
        this.business = true;
        this.model.business =  this.business;
        break;
      case true :
        this.business = false;
        this.model.business =  this.business;
        break;
    }
  }
}
