import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input() btnText: string = 'clique';
  @Input() btnType: string = '';
  @Output() clickChildren = new EventEmitter;
  textFilho = 'clicou no children';

  constructor() { }

  ngOnInit(): void {
  }

  clicou() {
    this.clickChildren.emit(this.textFilho);
  }

}
