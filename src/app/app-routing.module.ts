import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { PipeComponent } from './pipe/pipe.component';
import { CustompipeComponent } from './custompipe/custompipe.component';
import { NavComponent } from './nav/nav.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'pipe',component:PipeComponent},
  {path:'cpipe',component:CustompipeComponent},
  {path:'nav',component:NavComponent}


];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
