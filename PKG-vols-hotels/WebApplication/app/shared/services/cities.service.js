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
var CitiesService = (function () {
    function CitiesService(http) {
        this.http = http;
        this.c = [];
        this.searchStarted = new core_1.EventEmitter();
        this.searchCompleted = new core_1.EventEmitter();
    }
    CitiesService.prototype.searchCities = function () {
        var _this = this;
        this.searchStarted.emit();
        this.http.get("http://localhost:53046/api/cities").subscribe(function (res) {
            _this.c = res.json();
            console.log(_this.c.length + ' cities loaded');
            _this.searchCompleted.emit(_this.c);
        }, function (error) {
            _this.c = [];
            console.log(error);
            _this.searchCompleted.emit(_this.c);
        });
    };
    Object.defineProperty(CitiesService.prototype, "cities", {
        get: function () {
            return this.c;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(CitiesService.prototype, "citiesForAutocomplete", {
        get: function () {
            var obj = {};
            this.c.forEach(function (cityName) {
                obj[cityName] = null;
            });
            return obj;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(CitiesService.prototype, "searchStartedEvent", {
        get: function () {
            return this.searchStarted;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(CitiesService.prototype, "searchCompletedEvent", {
        get: function () {
            return this.searchCompleted;
        },
        enumerable: true,
        configurable: true
    });
    return CitiesService;
}());
CitiesService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], CitiesService);
exports.CitiesService = CitiesService;
//# sourceMappingURL=cities.service.js.map