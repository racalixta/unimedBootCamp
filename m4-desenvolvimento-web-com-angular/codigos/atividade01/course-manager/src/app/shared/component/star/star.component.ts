import { Component, Input, OnChanges, SimpleChanges } from "@angular/core";

@Component({
  selector: 'app-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnChanges {

  // como a info da star vem de fora, necessita ter o @Input()
  @Input()
  rating: number = 0;

  starWidth!: number;

  ngOnChanges(): void {
    this.starWidth = this.rating * 74 / 5;
  }
}
