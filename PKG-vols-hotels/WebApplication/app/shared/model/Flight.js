"use strict";
var Flight = (function () {
    function Flight(arrival_date, arrival_city, departure_date, departure_city, capacity, name, id, price) {
        this.arrival_date = arrival_date;
        this.arrival_city = arrival_city;
        this.departure_date = departure_date;
        this.departure_city = departure_city;
        this.capacity = capacity;
        this.name = name;
        this.id = id;
        this.price = price;
    }
    Flight.parseFlight = function (raw) {
        return new Flight(raw.ArrivalCity, raw.ArrivalDate, raw.DepartureCity, raw.DepartureDate, raw.Capacity, raw.Name, raw.IdVol, raw.Price);
    };
    return Flight;
}());
exports.Flight = Flight;
//# sourceMappingURL=Flight.js.map