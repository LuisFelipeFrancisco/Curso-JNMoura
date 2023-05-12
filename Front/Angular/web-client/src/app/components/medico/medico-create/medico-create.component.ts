import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-medico-create',
  templateUrl: './medico-create.component.html',
  styleUrls: ['./medico-create.component.css']
})
export class MedicoCreateComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  post(): void{
    this.goToIndex();
  }

  back(): void{
    this.goToIndex();
  }

  goToIndex(): void {
    this.router.navigate(['medico-index']);
  }

}
