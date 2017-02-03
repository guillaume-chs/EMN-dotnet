
export class JourneyResearch {
    constructor(
        public departure_date: Date,
        public departure_city: string,
        public arrival_city: string,
        public duration: number,
        public nb_passengers: number) {
    }
}