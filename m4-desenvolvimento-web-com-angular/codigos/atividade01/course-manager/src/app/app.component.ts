import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  // ^ "tag" q será colocada no html principal <app-root> </app-root>
  templateUrl: './app.component.html',
  // ^ o html q será utilizado por esse arquivo
  styleUrls: ['./app.component.css']
  // ^ o css que será utilizado
})
export class AppComponent {
  title = 'course-manager';

  name: string = 'John'
}
