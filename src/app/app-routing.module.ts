import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PipeexComponent } from './pipeex/pipeex.component';
import { HomeComponent } from './home/home.component';
import { AnimalsComponent } from './animals/animals.component';
import { NavComponent } from './nav/nav.component';
import { BindingComponent } from './binding/binding.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'pipeex',component:PipeexComponent},
  {path:'animals',component:AnimalsComponent},
  {path:'binding',component:BindingComponent},
  {path:'nav',component:NavComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
