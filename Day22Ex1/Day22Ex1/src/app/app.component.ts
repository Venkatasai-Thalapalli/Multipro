import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  teams:any[]=[
    {
      tid:1,tname:'rahul',temail:95000.50,desig:"manager",doj:'12/12/2021'
    },
  
    {
      id:2,name:'ram',salary:98000.50,desig:"devleoper",doj:'12/09/2019'
    },
  
    {
      id:3,name:'ravi',salary:95000.50,desig:"tester",doj:'05/12/2018'
    },
  
    {
      id:4,name:'raj',salary:95000.50,desig:"developer",doj:'12/05/2017'
    },
    
    {
      id:5,name:'suraj',salary:95000.50,desig:"tester",doj:'11/08/2018'
    },
   ];
}
