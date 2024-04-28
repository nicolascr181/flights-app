import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardFlightsComponent } from './card-flights.component';

describe('CardFlightsComponent', () => {
  let component: CardFlightsComponent;
  let fixture: ComponentFixture<CardFlightsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CardFlightsComponent]
    });
    fixture = TestBed.createComponent(CardFlightsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
