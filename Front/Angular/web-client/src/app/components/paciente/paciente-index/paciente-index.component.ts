import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-paciente-index',
  templateUrl: './paciente-index.component.html',
  styleUrls: ['./paciente-index.component.css']
})
export class PacienteIndexComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  create():void{
    this.router.navigate(['paciente-create']);
  }

}
