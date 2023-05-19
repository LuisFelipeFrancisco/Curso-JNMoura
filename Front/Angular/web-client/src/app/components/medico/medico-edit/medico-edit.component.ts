import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { take } from 'rxjs';
import { Medico } from 'src/app/models/medico.model';
import { MedicoService } from 'src/app/services/medico/medico.service';

@Component({
  selector: 'app-medico-edit',
  templateUrl: './medico-edit.component.html',
  styleUrls: ['./medico-edit.component.css']
})
export class MedicoEditComponent {

  medico: Medico;

  constructor(private router: Router,
    private activatedRoute: ActivatedRoute,
    private medicoService: MedicoService) {

    this.getById(this.getId());
    this.medico = new Medico();

  }

  getId(): number {
    return Number(this.activatedRoute.snapshot.paramMap.get('id')); // => retorna o id passado na rota
  }

  ngOnInit(): void { // => método executado quando o componente é carregado  
  }

  getById(id: number): void {
    this.medicoService.getById(id)
      .pipe(take(1))
      .subscribe({
        next: medico => this.handleResponseMedico(medico),
        error: error => this.handleResponseError(error.status)
      })
  }

  handleResponseMedico(medico: Medico): void {
    if (medico.DataNascimento != null)
      medico.DataNascimento = medico.DataNascimento.split('T')[0];
    this.medico = medico;
  }

  handleResponseError(error: number): void {
    this.exibirMensagem(error);
  }

  exibirMensagem(error: number): void {
    let mensagemCompleta: string = '';
    if (error == 404 || error == 400)
      mensagemCompleta = 'Médico não encontrado';
    else
      mensagemCompleta = 'Erro ao buscar médico, contate o suporte';
    alert(mensagemCompleta);
  }

  back(): void {
    this.router.navigate(['medico/medico-index']);
  }

  desejaAlterar(id: number) {
    if (confirm(`Deseja alterar médico ${id}?`))
      this.put(id);
  }

  put(id: number): void {
    this.medicoService.put(id, this.medico)
      .pipe(take(1))
      .subscribe({
        next: medico => this.handleResponseMedicoPut(medico),
        error: erro => this.handleResponseError(erro.status)
      });
  }

  handleResponseMedicoPut(medico: Medico): void {
    alert(`Médico ${medico.Nome} alterado com sucesso!`);
    this.back();
  }

}
