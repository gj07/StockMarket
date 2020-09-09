import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/Company';
import { AdminService } from 'src/app/Services/admin.service';

@Component({
  selector: 'app-view-companies',
  templateUrl: './view-companies.component.html',
  styleUrls: ['./view-companies.component.css']
})
export class ViewCompaniesComponent implements OnInit {
  list: Company[]
  constructor(private adminservice: AdminService) { }

  ngOnInit() {
    this.adminservice.getAllCompanies().subscribe(res => {
      this.list = res;
      console.log(this.list);
    }, error => {
      console.log(error);
      console.log(error.error.text);
    })
  }

}
