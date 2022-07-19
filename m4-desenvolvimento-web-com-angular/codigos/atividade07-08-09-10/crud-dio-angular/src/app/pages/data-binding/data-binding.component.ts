import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.css']
})
export class DataBindingComponent implements OnInit {

  text = 'Component -> DOM - interpolação';
  nome = 'Paulo';
  imgUrl = 'https://picsum.photos/300/300';
  imgDesc = 'descrição da imagem';
  textInput = '';
  number = 0;
  destroy= false;

  constructor() { }

  ngOnInit(): void {
  }

  retornaNome() {
    return this.nome;
  }

  clicou(value: any) {
    return console.log('não clique de novo!', value)
  }

  clicouNoFilho(text: any) {
    console.log(text);
  }

  incrementa() {
    this.number++;
  }

  destroiComponent() {
    this.destroy = true;
  }

}
