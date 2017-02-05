import { Injectable, EventEmitter } from '@angular/core';

@Injectable()
export class HotelsService {
    private h: any[] = [];
    private selectedIndex: number = -1;
    private hotelsChange: EventEmitter<any> = new EventEmitter();
    private hotelSelection: EventEmitter<any> = new EventEmitter();

    public searchHotels(): void {
        this.h = database;
        this.hotelsChange.emit(this.h);
    }

    public selectHotel(hotelId: number) {
        for (let i = 0; i < this.h.length; i++) {
            if (this.h[i].id === hotelId) {
                this.selectedIndex = i;
                this.hotelSelection.emit(this.h[i]);
                return;
            }
        }

        this.selectedIndex = -1;
    }

    public unselectHotel() {
        if (this.selectedIndex >= 0) {
            this.selectedIndex = -1;
            this.hotelSelection.emit(undefined);
        }
    }

    public get hotels(): any[] {
        return this.h;
    }

    public get selectedHotel(): any {
        if (this.selectedIndex >= 0) {
            return this.h[this.selectedIndex];
        } else {
            return -1;
        }
    }

    public get changeEventEmitter(): EventEmitter<any> {
        return this.hotelsChange;
    }

    public get selectionEventEmitter(): EventEmitter<any> {
        return this.hotelSelection;
    }
}


const database = [
    { id: 1, name: "Hôtel Paris", city: "Paris", price: "80", capacity: 20 },
    { id: 2, name: "Hôtel New York", city: "New York", price: "1700", capacity: 12 }
];
