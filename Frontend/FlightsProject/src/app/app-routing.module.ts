import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  {
    path : 'home',
    component: HomeComponent,
  },
  {
    path: '',
    redirectTo: '/home', // Redirect empty path to 'home'
    pathMatch: "full"
  },
  {
    path: '**', // Wildcard route for any other URL
    redirectTo: '/home', // Redirect empty path to 'home'
    
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
