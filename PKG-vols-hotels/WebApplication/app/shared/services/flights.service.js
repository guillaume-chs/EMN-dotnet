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
var http_1 = require("@angular/http");
var Flight_1 = require("../model/Flight");
var FlightsService = (function () {
    function FlightsService(http) {
        this.http = http;
        this.f = [];
        this.selectedIndex = -1;
        this.searchStarted = new core_1.EventEmitter();
        this.searchCompleted = new core_1.EventEmitter();
        this.flightSelection = new core_1.EventEmitter();
    }
    FlightsService.prototype.searchFlights = function (departureCity, arrivalCity, departureDate) {
        var _this = this;
        this.searchStarted.emit();
        var queryString = "?departureCity=" + departureCity + "&arrivalCity=" + arrivalCity + "&departureDate=" + departureDate;
        this.http.get("http://localhost:53046/api/flights/search" + queryString).subscribe(function (res) {
            _this.f = res.json().map(function (rawF) { return Flight_1.Flight.parseFlight(rawF); });
            _this.searchCompleted.emit(_this.f);
        }, function (error) {
            _this.searchCompleted.emit([]);
        });
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
            return (this.selectedIndex >= 0)
                ? this.f[this.selectedIndex]
                : -1;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(FlightsService.prototype, "searchStartedEvent", {
        get: function () {
            return this.searchStarted;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(FlightsService.prototype, "searchCompletedEvent", {
        get: function () {
            return this.searchCompleted;
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
    return FlightsService;
}());
FlightsService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], FlightsService);
exports.FlightsService = FlightsService;
//# sourceMappingURL=flights.service.js.map