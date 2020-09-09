import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Views/home/home.component';
import { AdminLoginComponent } from './Views/Admin/admin-login/admin-login.component';
import { UserLoginComponent } from './Views/User/user-login/user-login.component';
import { SignUpComponent } from './Views/User/sign-up/sign-up.component';
import { AdminLandingComponent } from './Views/Admin/admin-landing/admin-landing.component';
import { UserLandingComponent } from './Views/User/user-landing/user-landing.component';
import { ManageCompanyComponent } from './Views/Admin/manage-company/manage-company.component';
import { ViewCompaniesComponent } from './Views/Admin/view-companies/view-companies.component';
import { AccountService } from './Services/account.service';
import { HttpClientModule } from '@angular/common/http';
import { AdminService } from './Services/admin.service';
import { UserService } from './Services/user.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AdminLoginComponent,
    UserLoginComponent,
    SignUpComponent,
    AdminLandingComponent,
    UserLandingComponent,
    ManageCompanyComponent,
    ViewCompaniesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [AccountService, AdminService, UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
