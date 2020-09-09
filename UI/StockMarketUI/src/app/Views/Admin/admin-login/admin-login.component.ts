import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.css']
})
export class AdminLoginComponent implements OnInit {
  Username:string;
  Password:string;
  constructor(private account_service: AccountService, private router: Router) { }

  ngOnInit(): void {
  }

  validate(){
    if(this.Username == "admin12" && this.Password == "adminpass"){
      this.router.navigateByUrl('admin-landing');
    }else{
      alert('Invalid username or password');
    }
  }
}
