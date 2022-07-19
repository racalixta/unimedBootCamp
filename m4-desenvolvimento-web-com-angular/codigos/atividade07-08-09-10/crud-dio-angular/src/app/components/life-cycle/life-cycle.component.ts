import { AfterContentChecked, AfterContentInit, AfterViewChecked, AfterViewInit, Component, DoCheck, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-life-cycle',
  templateUrl: './life-cycle.component.html',
  styleUrls: ['./life-cycle.component.css']
})
export class LifeCycleComponent implements OnInit, OnChanges, DoCheck, AfterContentInit,
  AfterContentChecked, AfterViewInit, AfterViewChecked, OnDestroy {

  @Input() number = 10;

  constructor() {
    console.log('chamou o constructor');
  }

  ngOnChanges(): void {
    console.log('chamou o OnChanges');
  }

  ngOnInit(): void {
    console.log('chamou o OnInit');
  }

  ngDoCheck(): void {
    console.log('chamou o DoCheck');
  }

  ngAfterContentInit(): void {
    console.log('chamou o AfterContentInit');
  }

  ngAfterContentChecked(): void {
    console.log('chamou o AfterContentChecked');
  }

  ngAfterViewInit(): void {
    console.log('chamou o AfterViewInit');
  }

  ngAfterViewChecked(): void {
    console.log('chamou o AfterViewChecked');
  }

  ngOnDestroy(): void {
    console.log('chamou o OnDestroy');
  }

}
