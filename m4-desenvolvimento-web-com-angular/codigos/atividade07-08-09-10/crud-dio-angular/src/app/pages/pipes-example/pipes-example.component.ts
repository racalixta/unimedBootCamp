import { UpperCasePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes-example',
  templateUrl: './pipes-example.component.html',
  styleUrls: ['./pipes-example.component.css']
})
export class PipesExampleComponent implements OnInit {

  number = 0;
  text = 'Hello World';
  frase = 'Uma frase de exemplo pro slice'
  date = new Date;
  pessoa = {
    nome: 'Ivo',
    idade: '21',
    profissao: 'Dev',
  }
  nomes = ['Ivo'];

  constructor(private upperCasePipe: UpperCasePipe) { }

  ngOnInit(): void {
    this.text = this.upperCasePipe.transform(this.text);
  }

  mudaValor() {
    this.number = 21;
  }

  add(texto: string) {
    this.nomes.push(texto);
  }

}
