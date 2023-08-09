import { Component } from '@angular/core';

@Component({
  selector: 'app-pipe',
  templateUrl: './pipe.component.html',
  styleUrls: ['./pipe.component.css']
})
export class PipeComponent {
  emps:any[]=[
    {eid:1,ename:'sam',esalary:95000.50,edoj:'12/21/2019'},
    
    {eid:2,ename:'ravi',esalary:75000.50,edoj:'05/20/2019'},
    
    {eid:3,ename:'ram',esalary:55000.50,edoj:'09/15/2019'},
    
    {eid:4,ename:'rohit',esalary:90000.50,edoj:'08/15/2020'},
    
    {eid:5,ename:'jay',esalary:80000.50,edoj:'01/13/2019'}
  ];

}
