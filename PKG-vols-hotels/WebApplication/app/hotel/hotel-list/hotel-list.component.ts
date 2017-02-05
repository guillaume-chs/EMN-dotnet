import { Component, Input } from '@angular/core';

import { JourneyResearch } from '../../shared/model/JourneyResearch';
import { HotelsService } from '../../shared/services/hotels.service';
var module: any;

@Component({
    moduleId: module.id,
    selector: 'hotel-list',
    providers: [],
    templateUrl: './hotel-list.component.html',
    styles: [`
        tr.selected {
            background-color: #a8a8a8;
        }
        tr.selected:hover {
            background-color: #a8a8a8;
        }
    `]
})
export class HotelListComponent {
    hotels: any[] = [];
    selectedHotel: number = -1;
    submitted: boolean = false;

    constructor(private hotelsService: HotelsService) {
        this.hotelsService.changeEventEmitter.subscribe((hotels: any[]) => {
            this.hotels = hotels;
            this.submitted = false;
            this.selectedHotel = -1;
        });
    }

    selectHotel(index: number) {
        if (this.selectedHotel !== index) {
            this.selectedHotel = index;
        } else {
            this.selectedHotel = undefined;
        }
    }

    onSubmit() {
        this.hotelsService.selectHotel(this.selectedHotel);
        this.submitted = true;
    }
}
