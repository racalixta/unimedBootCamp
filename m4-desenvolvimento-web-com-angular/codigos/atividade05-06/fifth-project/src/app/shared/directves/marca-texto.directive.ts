import { Directive, ElementRef, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[appMarcaTexto]'
})
export class MarcaTextoDirective implements OnInit{

  @Input() corDeFundo = 'yellow';
  @Input() corDeTexto = 'white';

  constructor(private element: ElementRef) { }

  ngOnInit(): void {
    this.mudarFundo();
  }

  private mudarFundo(cor: string = 'yellow') {
    this.element.nativeElement.style.backgroundColor = this.corDeFundo || cor;
    this.element.nativeElement.style.color = this.corDeTexto;
    this.element.nativeElement.style.fontWieght = 'bold';
  }

}
