import { Injectable } from '@angular/core';
    
@Injectable()
export class ProductService {
    getProductsData() {
        return  [
            {
                Journey:{
                    Origin: "MZL",
                    Destination: "BCN",
                    Price: 3000.0,
                    Flights: [
                        {
                            Origin : "MZL",
                            Destination: "JFK",
                            Price: 1000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8020"
                            }
                        },
                        {
                            Origin : "JFK",
                            Destination: "BCN",
                            Price: 2000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8040"
                            }
                        }
                    ]
                }
            },
            {
                Journey:{
                    Origin: "MZL",
                    Destination: "BOG",
                    Price: 5000.0,
                    Flights: [
                        {
                            Origin : "MZL",
                            Destination: "PER",
                            Price: 2000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8020"
                            }
                        },
                        {
                            Origin : "PER",
                            Destination: "BOG",
                            Price: 3000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8040"
                            }
                        }
                    ]
                }
            },
            {
                Journey:{
                    Origin: "MZL",
                    Destination: "BOG",
                    Price: 5000.0,
                    Flights: [
                        {
                            Origin : "MZL",
                            Destination: "PER",
                            Price: 2000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8020"
                            }
                        },
                        {
                            Origin : "PER",
                            Destination: "BOG",
                            Price: 3000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8040"
                            }
                        }
                    ]
                }
            },
            {
                Journey:{
                    Origin: "MZL",
                    Destination: "BOG",
                    Price: 5000.0,
                    Flights: [
                        {
                            Origin : "MZL",
                            Destination: "PER",
                            Price: 2000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8020"
                            }
                        },
                        {
                            Origin : "PER",
                            Destination: "BOG",
                            Price: 3000.0,
                            Transport:{
                                FlightCarrier : "AV",
                                FlightNumber: "8040"
                            }
                        }
                    ]
                }
            },
            
        ]
        
    }

    getProducts() {
        return Promise.resolve(this.getProductsData());
    }
};