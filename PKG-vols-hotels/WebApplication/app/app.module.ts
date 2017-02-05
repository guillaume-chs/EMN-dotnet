import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SearchFormComponent } from './search-form/search-form.component';

import { FlightListComponent } from './flight/flight-list/flight-list.component';
import { FlightCardComponent } from './flight/flight-card/flight-card.component';
import { FlightsService } from './shared/services/flights.service';

import { HotelListComponent } from './hotel/hotel-list/hotel-list.component';
import { HotelCardComponent } from './hotel/hotel-card/hotel-card.component';
import { HotelsService } from './shared/services/hotels.service';

@NgModule(({
    imports: [
        BrowserModule,
        FormsModule
    ],
    declarations: [
        AppComponent,
        NavbarComponent,
        SearchFormComponent,
        FlightListComponent,
        FlightCardComponent,
        HotelListComponent,
        HotelCardComponent
    ],
    bootstrap: [AppComponent],
    providers: [
        FlightsService,
        HotelsService
    ]
}) as any)
export class AppModule { }
