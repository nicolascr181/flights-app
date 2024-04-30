# DcxAirProject

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 16.1.4.

## Development Server

To run a development server, use `ng serve`. Then, navigate to `http://localhost:4200/`. The application will automatically reload whenever you change any of the source files.

## Architecture
The project's focus was Clean Architecture, which comprises four different layers. We used a basic template available [here](https://github.com/ardalis/CleanArchitecture), and you can find a README file in each layer:

- Core (Domain layer): All entities, including Flight, Journey, and Transport, reside here.
- Use Cases (Application Layer): This layer contains all the business logic, including the flight route calculation. We implemented a Depth-First Search Algorithm to meet the requirements.
- API Layer: We implemented a single endpoint for retrieving journeys based on filters.
- Infrastructure: This layer handles configuration and database connection (SQLite).

## Design Principles
- We integrated multiple design principles into the solution, such as S.O.L.I.D, with a focus on single responsibility (each layer handles specific functionality) and extensive use of dependency injection to utilize different services in their respective layers.
- We adhered to the Y.A.G.N.I principle by not implementing functionalities that were not requested, such as a login page or additional UI filters.

## Functionalities
- Users can search for one-way and round-trip flights based on typed origin and destination.
- We have 4 unit tests for the core and use cases layers.
- A logging file is included in the project, a simple .txt file that registers every backend application event, such as requests and exceptions. This log is also connected to the debug console.
- We used a Depth-First Search algorithm to determine possible flight paths.
- Additionally, we used some libraries for handling message errors or exceptions such as Problem and ErrorOr
- The frontend app provides a message to inform users of the success or failure of their requests.

## Functionalities Missing
- Money conversion is incomplete; only the currency symbol is loaded from the backend for the total price.

## Areas for Improvement
- Implement more validations on the client-side, especially for form inputs.
- Store repetitive queries in a cache repository to improve application performance and response time, particularly when dealing with numerous flights and possible routes.
- For small projects, consider merging the domain and application layers.

## Versions

- .Net Core 8
- Node 18.16.1
- npm 9.5.1
- Angular CLI: 16.1.4

## Further Assistance

For more information on Angular CLI, use `ng help` or refer to the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.