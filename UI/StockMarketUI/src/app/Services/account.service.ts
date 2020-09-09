import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../Models/User';


@Injectable({
  providedIn: 'root'
})
export class AccountService {
  path:string = "http://localhost:51267/Account/";

  constructor(private http:HttpClient) { }

  public createUser(user: User): Observable<any> {
    return this.http.post<any>(this.path+'AddUser', user);
  }

  public validate(username:string, password:string): Observable<User> {
    return this.http.get<User>(this.path+`validate/${username}/${password}`);
  }
}
