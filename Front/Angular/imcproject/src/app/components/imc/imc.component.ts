import { Component } from '@angular/core';

@Component({
  selector: 'app-imc',
  templateUrl: './imc.component.html',
  styleUrls: ['./imc.component.css']
})
export class ImcComponent {

  altura: number;
  peso: number;
  imc: number;
  situacao: string;
  grauObesidade: string;

  constructor() {
    this.altura = 0;
    this.peso = 0;
    this.imc = 0;
    this.situacao = '';
    this.grauObesidade = '';
  }

  calcularImc() {
    this.imc = this.peso / (this.altura * this.altura);
    this.imc = parseFloat(this.imc.toFixed(2));
    switch (true) {
      case (this.imc < 18.5):
        this.situacao = 'Magreza';
        this.grauObesidade = '0';
        break;
      case (this.imc < 25):
        this.situacao = 'Normal';
        this.grauObesidade = '0';
        break;
      case (this.imc < 30):
        this.situacao = 'Sobrepeso';
        this.grauObesidade = 'I';
        break;
      case (this.imc < 40):
        this.situacao = 'Obesidade';
        this.grauObesidade = 'II';
        break;
      case (this.imc >= 40):
        this.situacao = 'Obesidade Grave';
        this.grauObesidade = 'III';
        break;
    }
  }

  limpar() {
    this.altura = 0;
    this.peso = 0;
    this.imc = 0;
    this.situacao = '';
    this.grauObesidade = '';
  }

}
