"use strict";
var Hotel = (function () {
    function Hotel(city, capacity, name, id, price) {
        this.city = city;
        this.capacity = capacity;
        this.name = name;
        this.id = id;
        this.price = price;
    }
    Hotel.parseHotel = function (raw) {
        return new Hotel(raw.City, raw.Capacity, raw.Name, raw.IdHotel, raw.Price);
    };
    return Hotel;
}());
exports.Hotel = Hotel;
//# sourceMappingURL=Hotel.js.map