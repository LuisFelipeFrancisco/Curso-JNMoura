import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-medico-index',
  templateUrl: './medico-index.component.html',
  styleUrls: ['./medico-index.component.css']
})
export class MedicoIndexComponent implements OnInit {
  
  constructor(private router:Router) { } //Injeção de Dependência => router

  ngOnInit(): void {
  }

  get():void{
    console.log("get");
  }

  create():void{
    this.router.navigate(['medico-create']);
  }
}
