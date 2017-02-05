﻿import { Injectable, EventEmitter } from '@angular/core';

@Injectable()
export class FlightsService {
    private f: any[] = [];
    private selectedIndex: number = -1;
    private flightsChange: EventEmitter<any> = new EventEmitter();
    private flightSelection: EventEmitter<any> = new EventEmitter();

    public searchFlights(): void {
        this.f = database;
        this.flightsChange.emit(this.f);
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
