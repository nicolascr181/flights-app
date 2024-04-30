import { Component, Input, OnInit } from '@angular/core';
import { IJourney } from './interfaces';

@Component({
  selector: 'app-list-flights-container',
  templateUrl: './list-flights-container.component.html',
  styleUrls: ['./list-flights-container.component.css']
})
export class ListFlightsContainerComponent implements OnInit {
  @Input() journeys?: IJourney[];

  constructor() {
  }

  ngOnInit() {
   
}

}
