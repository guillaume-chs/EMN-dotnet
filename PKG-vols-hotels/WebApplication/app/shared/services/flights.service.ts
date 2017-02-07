import { Injectable, EventEmitter } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Flight } from '../model/Flight';

@Injectable()
export class FlightsService {
    private f: Flight[] = [];
    private selectedIndex: number = -1;

    private searchStarted: EventEmitter<any> = new EventEmitter();
    private searchCompleted: EventEmitter<Flight[]> = new EventEmitter<Flight[]>();
    private flightSelection: EventEmitter<Flight> = new EventEmitter<Flight>();

    constructor(private  http: Http) {
    }

    public searchFlights(departureCity: string, arrivalCity: string, departureDate: string): void {
        this.searchStarted.emit();
        const queryString = `?departureCity=${departureCity}&arrivalCity=${arrivalCity}&departureDate=${departureDate}`;
        this.http.get("http://localhost:53046/api/flights/search" + queryString).subscribe(res => {
            this.f = res.json().map((rawF:any) => Flight.parseFlight(rawF));
            this.searchCompleted.emit(this.f);
        }, (error: any) => {
            this.searchCompleted.emit([]);
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
        return (this.selectedIndex >= 0)
            ? this.f[this.selectedIndex]
            : -1;
    }

    public get searchStartedEvent(): EventEmitter<any> {
        return this.searchStarted;
    }

    public get searchCompletedEvent(): EventEmitter<Flight[]> {
        return this.searchCompleted;
    }

    public get selectionEventEmitter(): EventEmitter<Flight> {
        return this.flightSelection;
    }
}