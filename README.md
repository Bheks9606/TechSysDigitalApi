# TechSysDigitalApi

#Introduction

This controller provides endpoints for managing musicians in the TechSysDigitalApi application.


#Endpoints:

#GET api/musicians
Retrieves a list of all musicians.

#GET api/musicians/{id}
Retrieves a specific musician by ID.

#POST api/musicians
Creates a new musician.

#PUT api/musicians/{id}
Updates an existing musician.

#DELETE api/musicians/{id}
Deletes an existing musician.


#Dependencies:

IMusicianRepository: Interface for interacting with the musician data source.
IMapper: AutoMapper instance for mapping between models and DTOs.


#Error Handling:

Returns a 500 status code with an error message in case of internal server errors.
Returns a 404 status code if a musician is not found.
Returns a 400 status code if there are model validation errors.

#Usage

Install the required dependencies.

1. Copy code
2. Make sure you have Visual Studio IDE
3. click Build on the top options and press Build solution
4. Run the application by pressing F5.

#Additional Notes:

The controller uses asynchronous methods for better performance.
It leverages AutoMapper for efficient model-to-DTO mapping.
The controller follows RESTful API conventions.
Usage Examples:

#To retrieve all musicians:
GET http://{YourLocalHost}/api/musicians

#To create a new musician:
POST http://{YourLocalHost}/api/musicians

#Example
Body: { "name": "John Doe", "stageName": "John D", "bio": "A talented musician", "genre": "Rock" }
