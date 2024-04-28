import { Component, Input } from '@angular/core';
import { Flight } from '../list-flights-container/interfaces';

@Component({
  selector: 'app-card-flights',
  templateUrl: './card-flights.component.html',
  styleUrls: ['./card-flights.component.css']
})
export class CardFlightsComponent {

  @Input() flights! : Flight[]

  constructor() {}

  ngOnInit() {

  }
  
}
