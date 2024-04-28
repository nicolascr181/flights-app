export interface Journey {
    Journey:{
        Origin: string,
        Destination: string,
        Price: number,
        Flights: Array<Flight>
    }
}

export interface Flight{
    Origin: string
    Destination: string
    Price: number
    Transport:{
        FlightCarrier : string
        FlightNumber: string
    }
}