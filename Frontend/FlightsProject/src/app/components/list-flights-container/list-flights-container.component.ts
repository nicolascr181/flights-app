import { Component, OnInit } from '@angular/core';
import { Flight, Journey } from './interfaces';
import { ProductService } from 'src/app/services/productservice';

@Component({
  selector: 'app-list-flights-container',
  templateUrl: './list-flights-container.component.html',
  styleUrls: ['./list-flights-container.component.css']
})
export class ListFlightsContainerComponent implements OnInit {
  journeys!: Journey[];
  origin!:string;
  destin!:string;
  flights! : Array<Flight>

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService.getProducts().
    then((journeys:Journey[]) => {
      this.journeys = journeys
      // this.origin = journey.Journey.Origin
      // this.destin = journey.Journey.Destination
      // this.flights = journey.Journey.Flights
    })
}

}
