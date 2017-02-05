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
var flights_service_1 = require('../../shared/services/flights.service');
var module;
var FlightCardComponent = (function () {
    function FlightCardComponent(flightsService) {
        var _this = this;
        this.flightsService = flightsService;
        this.flight = undefined;
        this.flightsService.selectionEventEmitter.subscribe(function (flight) {
            _this.flight = flight;
        });
    }
    FlightCardComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'flight-card',
            providers: [],
            templateUrl: './flight-card.component.html',
            styles: ["\n        .airplane-img {\n            min-width: 32px;\n            width: 15%;\n            margin-right: 1rem;\n        }\n        .airplane-content {\n            display: inline-block;\n            width: 66%;\n        }\n    "]
        }), 
        __metadata('design:paramtypes', [flights_service_1.FlightsService])
    ], FlightCardComponent);
    return FlightCardComponent;
}());
exports.FlightCardComponent = FlightCardComponent;
//# sourceMappingURL=flight-card.component.js.map