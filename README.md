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


#Additional Notes:

The controller uses asynchronous methods for better performance.
It leverages AutoMapper for efficient model-to-DTO mapping.
The controller follows RESTful API conventions.
Usage Examples:

#To retrieve all musicians:
GET http://localhost:5000/api/musicians

#To create a new musician:
POST http://localhost:5000/api/musicians

#Example
Body: { "name": "John Doe", "stageName": "John D", "bio": "A talented musician", "genre": "Rock" }
