import { Component, Input } from '@angular/core';

import { JourneyResearch } from '../../shared/model/JourneyResearch';
import { FlightsService } from '../../shared/services/flights.service';
var module: any;

@Component({
    moduleId: module.id,
    selector: 'flight-list',
    providers: [],
    templateUrl: './flight-list.component.html',
    styles: [`
        tr.selected {
            background-color: #a8a8a8;
        }
        tr.selected:hover {
            background-color: #a8a8a8;
        }
    `]
})
export class FlightListComponent {
    flights: any[] = [];
    selectedFlight: number = -1;
    submitted: boolean = false;

    constructor(private flightsService: FlightsService) {
        this.flightsService.changeEventEmitter.subscribe((flights: any[]) => {
            this.flights = flights;
            this.submitted = false;
            this.selectedFlight = -1;
        });
    }

    selectFlight(index: number) {
        if (this.selectedFlight !== index) {
            this.selectedFlight = index;
        } else {
            this.selectedFlight = undefined;
        }
    }

    onSubmit() {
        this.flightsService.selectFlight(this.selectedFlight);
        this.submitted = true;
    }
}
