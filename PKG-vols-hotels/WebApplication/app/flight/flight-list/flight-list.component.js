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
var core_1 = require("@angular/core");
var flights_service_1 = require("../../shared/services/flights.service");
var module;
var FlightListComponent = (function () {
    function FlightListComponent(flightsService) {
        var _this = this;
        this.flightsService = flightsService;
        this.flights = [];
        this.selectedFlight = -1;
        this.initialized = false;
        this.submitted = false;
        this.loading = false;
        this.flightsService.searchStartedEvent.subscribe(function () {
            _this.loading = true;
            if (!_this.initialized)
                _this.initialized = true;
        });
        this.flightsService.selectionEventEmitter.subscribe(function (flight) {
            if (!flight) {
                _this.selectedFlight = -1;
                _this.submitted = false;
            }
        });
        this.flightsService.searchCompletedEvent.subscribe(function (flights) {
            _this.flights = flights;
            _this.submitted = false;
            _this.selectedFlight = -1;
            _this.loading = false;
        });
    }
    FlightListComponent.prototype.selectFlight = function (index) {
        if (this.selectedFlight !== index) {
            this.selectedFlight = index;
        }
        else {
            this.selectedFlight = undefined;
        }
    };
    FlightListComponent.prototype.onSubmit = function () {
        this.flightsService.selectFlight(this.selectedFlight);
        this.submitted = true;
    };
    return FlightListComponent;
}());
FlightListComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'flight-list',
        providers: [],
        templateUrl: './flight-list.component.html',
        styles: ["\n        tr.selected {\n            background-color: #a8a8a8;\n        }\n        tr.selected:hover {\n            background-color: #a8a8a8;\n        }\n    "]
    }),
    __metadata("design:paramtypes", [flights_service_1.FlightsService])
], FlightListComponent);
exports.FlightListComponent = FlightListComponent;
//# sourceMappingURL=flight-list.component.js.map