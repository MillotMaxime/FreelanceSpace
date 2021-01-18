import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private accountService: AccountService) {}

  ngOnInit(): void {
    this.model.business = false;
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

  isBusiness(value) {
    if(value == "Entreprise") {
      this.model.business = true;
      return true;
    } else {
      return false;
    }
  }
}
