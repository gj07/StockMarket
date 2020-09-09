import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Company } from '../Models/Company';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  path: string = "http://localhost:51267/Admin/";

  constructor(private http:HttpClient) { }

  public getAllCompanies(): Observable<Company[]>{
    return this.http.get<Company[]>(this.path + 'companies/all');
  }

  public getCompany(CompanyCode: string): Observable<Company>{
    return this.http.get<Company>(this.path + `companies/${CompanyCode}`);
  }

  public addCompany(company: Company): Observable<any>{
    return this.http.post<any>(this.path + 'companies', company);
  }

  public updateCompany(company: Company): Observable<any>{
    return this.http.put<any>(this.path + 'companies', company);
  }

  public deleteCompany(CompanyCode: string): Observable<any>{
    return this.http.delete<any>(this.path + `companies/${CompanyCode}`);
  }

}
