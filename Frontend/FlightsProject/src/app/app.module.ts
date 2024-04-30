import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { SearchFlightsComponent } from './components/search-flights/search-flights.component';
import { ListFlightsContainerComponent } from './components/list-flights-container/list-flights-container.component';
import { CardFlightsComponent } from './components/card-flights/card-flights.component';
import { PrimeNGModule } from './primeng.module';
import { ReactiveFormsModule } from '@angular/forms';
import { JourneyService } from './services/journey.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SearchFlightsComponent,
    ListFlightsContainerComponent,
    CardFlightsComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    PrimeNGModule,
    HttpClientModule
  ],
  providers: [JourneyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
