import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { take } from 'rxjs';
import { Medico } from 'src/app/models/medico.model';
import { MedicoService } from 'src/app/services/medico/medico.service';

@Component({
  selector: 'app-medico-index',
  templateUrl: './medico-index.component.html',
  styleUrls: ['./medico-index.component.css']
})
export class MedicoIndexComponent implements OnInit {

  medicos: Medico[];
  
  constructor(private router:Router, 
              private medicoService:MedicoService) //Injeção de Dependência => router, medicoService
  { 
    this.medicos = new Array<Medico>();
  } 

  ngOnInit(): void {
  }

  get():void{
    this.medicoService.getAll()
      .pipe(take(1))
      .subscribe(medicos => this.medicos = medicos);
  }

  create():void{
    this.router.navigate(['medico-create']);
  }
}
