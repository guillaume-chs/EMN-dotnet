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
var hotels_service_1 = require("../../shared/services/hotels.service");
var module;
var HotelListComponent = (function () {
    function HotelListComponent(hotelsService) {
        var _this = this;
        this.hotelsService = hotelsService;
        this.hotels = [];
        this.selectedHotel = -1;
        this.initialized = false;
        this.submitted = false;
        this.loading = false;
        this.hotelsService.searchStartedEvent.subscribe(function () {
            _this.loading = true;
            if (!_this.initialized)
                _this.initialized = true;
        });
        this.hotelsService.selectionEventEmitter.subscribe(function (hotel) {
            if (!hotel) {
                _this.selectedHotel = -1;
                _this.submitted = false;
            }
        });
        this.hotelsService.searchCompletedEvent.subscribe(function (hotels) {
            _this.hotels = hotels;
            _this.submitted = false;
            _this.selectedHotel = -1;
            _this.loading = false;
        });
    }
    HotelListComponent.prototype.selectHotel = function (index) {
        if (this.selectedHotel !== index) {
            this.selectedHotel = index;
        }
        else {
            this.selectedHotel = undefined;
        }
    };
    HotelListComponent.prototype.onSubmit = function () {
        this.hotelsService.selectHotel(this.selectedHotel);
        this.submitted = true;
    };
    return HotelListComponent;
}());
HotelListComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'hotel-list',
        providers: [],
        templateUrl: './hotel-list.component.html',
        styles: ["\n        tr.selected {\n            background-color: #a8a8a8;\n        }\n        tr.selected:hover {\n            background-color: #a8a8a8;\n        }\n    "]
    }),
    __metadata("design:paramtypes", [hotels_service_1.HotelsService])
], HotelListComponent);
exports.HotelListComponent = HotelListComponent;
//# sourceMappingURL=hotel-list.component.js.map