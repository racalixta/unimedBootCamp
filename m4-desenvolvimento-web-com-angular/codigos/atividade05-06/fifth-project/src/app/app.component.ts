import { Component, OnInit } from '@angular/core';
import { PeopleService } from './shared/services/people.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  count = 0;
  nome = 'João Silva Santos';
  text = '';

  pessoas = [
    {
      firstName: '',
      lastName: '',
      age: 0,
    }
  ];

  constructor(private peopleService: PeopleService) { }

  ngOnInit(): void {
    this.getPeoples()
    console.log(this.pessoas);
    let interval = setInterval(() => {
      this.count++;
      if(this.count === 10) {
        clearInterval(interval);
      }
    }, 1000)
  }

  clicou(nome: string): void {
    console.log(`${nome} clicou no botão`);
  }

  getPeoples() {
    this.peopleService.getPeople().subscribe((people) => {
      this.pessoas = people;
    })
  }

}




