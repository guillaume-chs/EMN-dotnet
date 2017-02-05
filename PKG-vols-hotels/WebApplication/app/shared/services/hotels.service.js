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
var HotelsService = (function () {
    function HotelsService() {
        this.h = [];
        this.selectedIndex = -1;
        this.hotelsChange = new core_1.EventEmitter();
        this.hotelSelection = new core_1.EventEmitter();
    }
    HotelsService.prototype.searchHotels = function () {
        this.h = database;
        this.hotelsChange.emit(this.h);
    };
    HotelsService.prototype.selectHotel = function (hotelId) {
        for (var i = 0; i < this.h.length; i++) {
            if (this.h[i].id === hotelId) {
                this.selectedIndex = i;
                this.hotelSelection.emit(this.h[i]);
                return;
            }
        }
        this.selectedIndex = -1;
    };
    HotelsService.prototype.unselectHotel = function () {
        if (this.selectedIndex >= 0) {
            this.selectedIndex = -1;
            this.hotelSelection.emit(undefined);
        }
    };
    Object.defineProperty(HotelsService.prototype, "hotels", {
        get: function () {
            return this.h;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(HotelsService.prototype, "selectedHotel", {
        get: function () {
            if (this.selectedIndex >= 0) {
                return this.h[this.selectedIndex];
            }
            else {
                return -1;
            }
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(HotelsService.prototype, "changeEventEmitter", {
        get: function () {
            return this.hotelsChange;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(HotelsService.prototype, "selectionEventEmitter", {
        get: function () {
            return this.hotelSelection;
        },
        enumerable: true,
        configurable: true
    });
    HotelsService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [])
    ], HotelsService);
    return HotelsService;
}());
exports.HotelsService = HotelsService;
var database = [
    { id: 1, name: "Hôtel Paris", city: "Paris", price: "80", capacity: 20 },
    { id: 2, name: "Hôtel New York", city: "New York", price: "1700", capacity: 12 }
];
//# sourceMappingURL=hotels.service.js.map