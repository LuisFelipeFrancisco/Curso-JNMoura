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
  codigoPesquisa: string;

  constructor(private router: Router,
    private medicoService: MedicoService) //Injeção de Dependência => router, medicoService
  {
    this.medicos = new Array<Medico>();
    this.codigoPesquisa = '';
  }

  ngOnInit(): void {
  }

  get(): void {
    this.medicos = [] // limpa o array de médicos
    if (this.codigoPesquisa === '')
      this.getAll();
    else
      this.getById(Number(this.codigoPesquisa)); // Number() => converte string para number
  }

  getAll(): void {
    this.medicoService.getAll()
      .pipe(take(1))
      .subscribe({
        next: medicos => this.handleResponseMedicos(medicos),
        error: erro => this.handleResponseError(erro.status)
      });
  }

  getById(id: number): void {
    this.medicoService.getById(id)
      .pipe(take(1))
      .subscribe({
        next: medico => this.handleResponseMedico(medico),
        error: erro => this.handleResponseError(erro.status)
      });
  }

  handleResponseMedicos(medicos: Medico[]): void {
    this.medicos = medicos;
  }

  handleResponseMedico(medico: Medico): void {
    this.medicos.push(medico);
  }

  handleResponseError(erro: number): void {
    this.exibirMensagemErro(erro);
  }

  exibirMensagemErro(erro: number): void {
    let mensagemCompleta: string = '';
    if (erro === 404 || erro === 400)
      mensagemCompleta = "Médico não foi encontrado.";
    else
      mensagemCompleta = 'Ocorreu um erro! Entre em contato com suporte.';
    alert(mensagemCompleta);
  }

  create(): void {
    this.router.navigate(['medico/medico-create']);
  }

  editar(id: number): void {
    this.router.navigate(['medico/medico-edit', id]);
  }

  excluir(id: number): void {
    this.medicoService.delete(id)
      .pipe(take(1))
      .subscribe({
        next: response => this.get(), // response == null
        error: erro => this.handleResponseError(erro.status)
      });
  }

  desejaExcluir(id: number): void {
    if (confirm('Deseja excluir o médico?'))
      this.excluir(id);
  }

}
