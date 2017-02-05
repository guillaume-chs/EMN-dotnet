"use strict";
var JourneyResearch = (function () {
    function JourneyResearch(departure_date, departure_city, arrival_city, duration, nb_passengers) {
        this.departure_date = departure_date;
        this.departure_city = departure_city;
        this.arrival_city = arrival_city;
        this.duration = duration;
        this.nb_passengers = nb_passengers;
    }
    Object.defineProperty(JourneyResearch.prototype, "isValid", {
        get: function () {
            return (this.departure_city.length > 0) &&
                (this.departure_date.length > 0) &&
                (this.arrival_city.length > 0) &&
                (this.duration > 0) &&
                (this.nb_passengers > 0);
        },
        enumerable: true,
        configurable: true
    });
    return JourneyResearch;
}());
exports.JourneyResearch = JourneyResearch;
//# sourceMappingURL=JourneyResearch.js.map