import { Injectable, EventEmitter } from '@angular/core';
import { Http, Response } from '@angular/http';

@Injectable()
export class FlightsService {
    private f: any[] = [];
    private selectedIndex: number = -1;
    private flightsChange: EventEmitter<any> = new EventEmitter();
    private flightSelection: EventEmitter<any> = new EventEmitter();

    constructor(public http: Http) {
    }

    public searchFlights(departureCity: string, arrivalCity: string, departureDate: string): void {
        const queryString = `?departureCity=${departureCity}&arrivalCity=${arrivalCity}&departureDate=${departureDate}`;

        this.http.get("http://localhost:53046/api/flights/search" + queryString).subscribe(res => {
            console.log(res.json());

            this.f = res.json();
            this.flightsChange.emit(this.f);
        });
    }

    public selectFlight(flightId: number) {
        for (let i = 0; i < this.f.length; i++) {
            if (this.f[i].id === flightId) {
                this.selectedIndex = i;
                this.flightSelection.emit(this.f[i]);
                return;
            }
        }

        this.selectedIndex = -1;
    }

    public unselectFlight() {
        if (this.selectedIndex >= 0) {
            this.selectedIndex = -1;
            this.flightSelection.emit(undefined);
        }
    }

    public get flights(): any[] {
        return this.f;
    }

    public get selectedFlight(): any {
        if (this.selectedIndex >= 0) {
            return this.f[this.selectedIndex];
        } else {
            return -1;
        }
    }

    public get changeEventEmitter(): EventEmitter<any> {
        return this.flightsChange;
    }

    public get selectionEventEmitter(): EventEmitter<any> {
        return this.flightSelection;
    }
}


const database = [
    { id: 1, name: "Paris - Nantes", departure_date: "07/02/2017", price: "40", capacity: 120 },
    { id: 2, name: "Bordeaux - New York", departure_date: "14/02/2017", price: "700", capacity: 700 }
];
