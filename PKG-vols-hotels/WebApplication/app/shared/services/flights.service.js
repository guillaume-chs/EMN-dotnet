"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var FlightsService = (function () {
    function FlightsService() {
        this.f = [];
        this.selectedIndex = -1;
        this.flightsChange = new core_1.EventEmitter();
        this.flightSelection = new core_1.EventEmitter();
    }
    FlightsService.prototype.searchFlights = function () {
        this.f = database;
        this.flightsChange.emit(this.f);
    };
    FlightsService.prototype.selectFlight = function (flightId) {
        for (var i = 0; i < this.f.length; i++) {
            if (this.f[i].id === flightId) {
                this.selectedIndex = i;
                this.flightSelection.emit(this.f[i]);
                return;
            }
        }
        this.selectedIndex = -1;
    };
    FlightsService.prototype.unselectFlight = function () {
        if (this.selectedIndex >= 0) {
            this.selectedIndex = -1;
            this.flightSelection.emit(undefined);
        }
    };
    Object.defineProperty(FlightsService.prototype, "flights", {
        get: function () {
            return this.f;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(FlightsService.prototype, "selectedFlight", {
        get: function () {
            if (this.selectedIndex >= 0) {
                return this.f[this.selectedIndex];
            }
            else {
                return -1;
            }
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(FlightsService.prototype, "changeEventEmitter", {
        get: function () {
            return this.flightsChange;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(FlightsService.prototype, "selectionEventEmitter", {
        get: function () {
            return this.flightSelection;
        },
        enumerable: true,
        configurable: true
    });
    FlightsService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [])
    ], FlightsService);
    return FlightsService;
}());
exports.FlightsService = FlightsService;
var database = [
    { id: 1, name: "Paris - Nantes", departure_date: "07/02/2017", price: "40", capacity: 120 },
    { id: 2, name: "Bordeaux - New York", departure_date: "14/02/2017", price: "700", capacity: 700 }
];
//# sourceMappingURL=flights.service.js.map