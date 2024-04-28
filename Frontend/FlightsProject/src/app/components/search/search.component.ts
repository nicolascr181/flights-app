import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Currency, TripType } from './enums';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit{

  form: FormGroup;
  currencies: Currency[] = Object.values(Currency);
  tripTypes: TripType[] = Object.values(TripType);
 
  constructor(private fb: FormBuilder){
    this.form = this.fb.group({
      origin: ['', Validators.required],
      destin: ['', Validators.required],
      selectedTripType: [TripType.Oneway,Validators.required],
      selectedCurrency: [Currency.USD,Validators.required]
    });
  }
  ngOnInit(): void {
  }

  search(){
    console.log(this.form.getRawValue())
  }

}
