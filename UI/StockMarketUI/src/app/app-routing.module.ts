import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Views/home/home.component';
import { AdminLoginComponent } from './Views/Admin/admin-login/admin-login.component';
import { UserLoginComponent } from './Views/User/user-login/user-login.component';
import { SignUpComponent } from './Views/User/sign-up/sign-up.component';
import { AdminLandingComponent } from './Views/Admin/admin-landing/admin-landing.component';
import { UserLandingComponent } from './Views/User/user-landing/user-landing.component';
import { ManageCompanyComponent } from './Views/Admin/manage-company/manage-company.component';
import { ViewCompaniesComponent } from './Views/Admin/view-companies/view-companies.component';


const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'admin-login', component: AdminLoginComponent},
  {path: 'user-login', component: UserLoginComponent},
  {path: 'user-signup', component: SignUpComponent},
  {path: 'admin-landing', component: AdminLandingComponent},
  {path: 'user-landing', component: UserLandingComponent},
  {path: 'manage-company', component: ManageCompanyComponent},
  {path: 'view-companies', component: ViewCompaniesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
