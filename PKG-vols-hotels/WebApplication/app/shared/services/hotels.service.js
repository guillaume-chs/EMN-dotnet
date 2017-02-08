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
var HotelsService = (function () {
    function HotelsService(http) {
        this.http = http;
        this.h = [];
        this.selectedIndex = -1;
        this.searchStarted = new core_1.EventEmitter();
        this.searchCompleted = new core_1.EventEmitter();
        this.hotelSelection = new core_1.EventEmitter();
    }
    HotelsService.prototype.searchHotels = function () {
        var _this = this;
        this.searchStarted.emit();
        var queryString = "?";
        this.http.get("http://localhost:53046/api/hotels" + queryString).subscribe(function (res) {
            _this.h = res.json();
            _this.searchCompleted.emit(_this.h);
        }, function (error) {
            _this.h = [];
            console.log(error);
            _this.searchCompleted.emit(_this.h);
        });
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
            return (this.selectedIndex >= 0)
                ? this.h[this.selectedIndex]
                : -1;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(HotelsService.prototype, "searchStartedEvent", {
        get: function () {
            return this.searchStarted;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(HotelsService.prototype, "searchCompletedEvent", {
        get: function () {
            return this.searchCompleted;
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
    return HotelsService;
}());
HotelsService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], HotelsService);
exports.HotelsService = HotelsService;
//# sourceMappingURL=hotels.service.js.map