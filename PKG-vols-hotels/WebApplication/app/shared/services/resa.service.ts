import { Injectable, EventEmitter } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Flight } from '../model/Flight';
import { Hotel } from '../model/Hotel';

@Injectable()
export class ResaService {
    constructor(private http: Http) {
    }

    public reserveVoyage(vol: Flight, hotel: Hotel, lastname: string, firstname: string) {
        const queryString = `?hotelId=${hotel.id}&volId=${vol.id}&lastname=${lastname}&firstname=${firstname}`;
        return this.http.get("http://localhost:53046/api/reserve" + queryString);
    }
}