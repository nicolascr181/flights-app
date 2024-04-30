import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { TripType } from './enums';
import { ICurrency } from '../list-flights-container/interfaces';

@Component({
  selector: 'app-search-flights',
  templateUrl: './search-flights.component.html',
  styleUrls: ['./search-flights.component.css']
})
export class SearchFlightsComponent implements OnInit{

  form: FormGroup;
 
  currencies: ICurrency[] = [ 
    {name : "USD" ,code :"en-US"},
    {name : "YEN" ,code :"ja-JP"},
    {name : "EUR" ,code :"es-ES"},
   ]
  tripTypes: TripType[] = Object.values(TripType);
  @Output() searchEvent: EventEmitter<any> = new EventEmitter();
  
 
  constructor(private fb: FormBuilder){
    this.form = this.fb.group({
      origin: ['', Validators.required],
      destination: ['', Validators.required],
      tripType: [TripType.Oneway,Validators.required],
      currencyType: [this.currencies[0].code,Validators.required]
    });
  }
  ngOnInit(): void {
  }

  search(){
    this.searchEvent.emit(this.form.getRawValue());
  }

}
