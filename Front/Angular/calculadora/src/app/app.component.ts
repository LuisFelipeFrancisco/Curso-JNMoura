import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'calculadora';

  numero1: number;
  numero2: number;
  resultado: number;
  divisaoPorZero: boolean;


  constructor() { 
    this.numero1 = 0;
    this.numero2 = 0;
    this.resultado = 0;
    this.divisaoPorZero = false;
  }

  somar(): void {
    this.resultado = this.numero1 + this.numero2;
    this.divisaoPorZero = false;
  }

  subtrair(): void {
    this.resultado = this.numero1 - this.numero2;
    this.divisaoPorZero = false;
  }

  multiplicar(): void {
    this.resultado = this.numero1 * this.numero2;
    this.divisaoPorZero = false;
  }

  dividir(): void {
    if (this.numero2 !== 0) {
      this.resultado = this.numero1 / this.numero2;
      this.divisaoPorZero = false;
    }
    else {
      this.divisaoPorZero = true;
    }
  }

  limpar(): void {
    this.numero1 = 0;
    this.numero2 = 0;
    this.resultado = 0;
  }
  
}

