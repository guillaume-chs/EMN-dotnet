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
var hotels_service_1 = require('../../shared/services/hotels.service');
var module;
var HotelCardComponent = (function () {
    function HotelCardComponent(hotelsService) {
        var _this = this;
        this.hotelsService = hotelsService;
        this.hotel = undefined;
        this.hotelsService.selectionEventEmitter.subscribe(function (hotel) {
            _this.hotel = hotel;
            console.log(_this.hotel);
        });
    }
    HotelCardComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'hotel-card',
            providers: [],
            templateUrl: './hotel-card.component.html',
            styles: ["\n        .hotel-img {\n            min-width: 32px;\n            width: 15%;\n            margin-right: 1rem;\n        }\n        .hotel-content {\n            display: inline-block;\n            width: 66%;\n        }\n    "]
        }), 
        __metadata('design:paramtypes', [hotels_service_1.HotelsService])
    ], HotelCardComponent);
    return HotelCardComponent;
}());
exports.HotelCardComponent = HotelCardComponent;
//# sourceMappingURL=hotel-card.component.js.map