import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListFlightsContainerComponent } from './list-flights-container.component';

describe('ListFlightsContainerComponent', () => {
  let component: ListFlightsContainerComponent;
  let fixture: ComponentFixture<ListFlightsContainerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListFlightsContainerComponent]
    });
    fixture = TestBed.createComponent(ListFlightsContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
