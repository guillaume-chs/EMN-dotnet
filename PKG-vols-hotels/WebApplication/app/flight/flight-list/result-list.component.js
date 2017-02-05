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
var flights_service_1 = require('../shared/services/flights.service');
var module;
var ResultListComponent = (function () {
    function ResultListComponent(flightsService) {
        var _this = this;
        this.flightsService = flightsService;
        this.flights = [];
        this.selectedFlight = -1;
        this.submitted = false;
        this.flightsService.changeEventEmitter.subscribe(function (flights) {
            _this.flights = flights;
            _this.submitted = false;
            _this.selectedFlight = -1;
        });
    }
    ResultListComponent.prototype.selectFlight = function (index) {
        if (this.selectedFlight !== index) {
            this.selectedFlight = index;
        }
        else {
            this.selectedFlight = undefined;
        }
    };
    ResultListComponent.prototype.onSubmit = function () {
        this.flightsService.selectFlight(this.selectedFlight);
        this.submitted = true;
    };
    ResultListComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'result-list',
            providers: [],
            templateUrl: './result-list.component.html',
            styles: ["\n        tr.selected {\n            background-color: #a8a8a8;\n        }\n        tr.selected:hover {\n            background-color: #a8a8a8;\n        }\n    "]
        }), 
        __metadata('design:paramtypes', [(typeof (_a = typeof flights_service_1.FlightsService !== 'undefined' && flights_service_1.FlightsService) === 'function' && _a) || Object])
    ], ResultListComponent);
    return ResultListComponent;
    var _a;
}());
exports.ResultListComponent = ResultListComponent;
//# sourceMappingURL=result-list.component.js.map