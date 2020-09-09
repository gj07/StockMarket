import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/Company';
import { AdminService } from 'src/app/Services/admin.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-manage-company',
  templateUrl: './manage-company.component.html',
  styleUrls: ['./manage-company.component.css']
})
export class ManageCompanyComponent implements OnInit {
  CompanyCode:string;
  CompanyName:string;
  CEO:string;
  BoardOfDirectors:string;
  StockExchangesListedOn:string;
  ListOfCompanies: Company[] = [];
  company: Company;

  constructor(private service: AdminService, private router: Router) { }

  ngOnInit() {
  }

  public get(){
    this.service.getCompany(this.CompanyCode).subscribe(i => {
      this.company = i;
      console.log(this.company);
      localStorage.setItem('company', JSON.stringify(this.company));
    }, error => {
      console.log(error);
      console.log(error.error.text);
    })
  }

  public add(){
    this.company = {
      CompanyCode: this.CompanyCode,
      CompanyName: this.CompanyName,
      CEO: this.CEO,
      BoardOfDirectors: this.BoardOfDirectors,
      StockExchangesListedOn: this.StockExchangesListedOn
    };
    
    console.log(this.company);
    this.service.addCompany(this.company).subscribe(res => {
      console.log(res);
    }, error => {
      console.log(error);
      console.log(error.error.text);
    })
  }

  public update(){
    this.company = {
      CompanyCode: this.CompanyCode,
      CompanyName: this.CompanyName,
      CEO: this.CEO,
      BoardOfDirectors: this.BoardOfDirectors,
      StockExchangesListedOn: this.StockExchangesListedOn
    };

    console.log(this.company);
    this.service.updateCompany(this.company).subscribe(res => {
      console.log(res);
    }, error => {
      console.log(error);
      console.log(error.error.text);
    })
  }

  public delete(){
    this.service.deleteCompany(this.CompanyCode).subscribe(res => {
      console.log(res);
    }, error => {
      console.log(error);
      console.log(error.error.text);
    })
  }
}
