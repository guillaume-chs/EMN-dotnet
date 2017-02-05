import { Injectable, EventEmitter } from '@angular/core';

@Injectable()
export class CitiesService {
    private c: any = {};

    constructor() {
        this.c = database;
    }

    public get cities(): any[] {
        return this.c;
    }
}


const database = {
    "Paris": <any>null,
    "Nantes": <any>null,
    "New York": <any>null,
    "Bordeaux": <any>null
};
