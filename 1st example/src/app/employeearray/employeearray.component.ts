import { Component, OnInit } from '@angular/core';

//Component Directive
@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {

 
  constructor() { }

  people:any[]=[
    {"name":"Sai", "age":22, "dept":"HR"},
     {"name":"Ezhil", "age":27, "dept":"Sales"},
    {"name":"Ravi", "age":25, "dept":"HR"},
    {"name":"Ammu", "age":23, "dept":"Finance"},
    {"name":"Banu", "age":24, "dept":"Development"},
     {"name":"Linu", "age":24, "dept":"Sales"}
    ];
  ngOnInit(): void {
  }

}
