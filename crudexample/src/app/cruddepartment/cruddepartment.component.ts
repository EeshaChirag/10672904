import { Component, OnInit } from '@angular/core';
import{Department} from '../models/department.model';

@Component({
  selector: 'app-cruddepartment',
  templateUrl: './cruddepartment.component.html',
  styleUrls: ['./cruddepartment.component.css'],
})
export class CruddepartmentComponent implements OnInit {

  dept:Department[]=[
    {deptid:1001,dname:"UX",location:"Pune"},
    {deptid:1002,dname:"Development",location:"Pune"},
    {deptid:1003,dname:"Sales",location:"Mumbai"},
    {deptid:1004,dname:"HR",location:"Chennai"}
    ];

    getdeptinfo:any={};
  constructor() {
     
   }

   AddDepartment()
    {
	    this.dept.push(this.getdeptinfo);
      this.getdeptinfo={};
      alert("Department Added");
    }

    DeleteDepartment(i)
    {
        console.log(i);
        this.dept.splice(i,1);
        alert("Department Deleted");
    }

  indexvalue;
  EditDepartment(i)
  {
	  this.getdeptinfo.deptid=this.dept[i].deptid;
	  this.getdeptinfo.dname=this.dept[i].dname;
	  this.getdeptinfo.location=this.dept[i].location;
	  this.indexvalue=i;
  }

  UpdateDepartment()
  {
	  let k=this.indexvalue;
	  for(let i=0;i<this.dept.length;i++)
	  {
		  if(k==i)
		  {
			  this.dept[i]=this.getdeptinfo;
        this.getdeptinfo={};
        alert("Department updated");
		  }
	  }
  }

  ngOnInit(): void {
  }

}
