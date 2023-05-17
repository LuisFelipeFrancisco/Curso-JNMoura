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
      .subscribe({
        next: medicos => this.handleResponse(medicos),
        error: erro => this.handleResponseError(erro.status)
      });          
  }

  handleResponse(medicos: Medico[]):void{
    this.medicos = medicos;
  }

  handleResponseError(erro:number):void{
    this.exibirMensagemErro(erro);
  }

  exibirMensagemErro(erro: number):void{
    let mensagemCompleta:string = '';
    if (erro === 404 || erro === 400)
        mensagemCompleta = "Médico não foi encontrado.";
    else    
        mensagemCompleta = 'Ocorreu um erro! Entre em contato com suporte.';
    alert(mensagemCompleta);
  }

  create():void{
    this.router.navigate(['medico-create']);
  }

  editar(id:number):void{
    console.log(id);
  }

  desejaExcluir(id:number):void{
    console.log(id);
  }
}
