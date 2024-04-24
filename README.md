# CoffeeShop Mobile Application Backend
## Overview

This repository contains the backend services for the CoffeeShop Mobile Application. It's designed to manage the data interaction between the mobile application and the backend server.

## Technologies and Frameworks Used
- **.NET 7**
- **Entity Framework Core**: Used for database operations, leveraging LINQ queries to interact with Microsoft SQL Server.

## API Endpoints
### Menus

- **GET /api/menus** : Retrieves all menus with their corresponding submenus using eager loading.

- **GET /api/menus/{id}**: Retrieves a specific menu by its ID, including submenu details.
  
### Reservations
- **POST /api/reservations**: This endpoint is responsible for creating a new reservation in the database. It accepts a Reservation object as input, which includes necessary details such as the customer's name, email, phone number, total people, date, and time of the reservation.

## Error Handling and Validation
- **Not Found**: If a request is made for a menu ID that does not exist in the database, the API responds with a 404 Not Found, indicating that the requested resource is unavailable.
-**Data Validation**: Ensuring that the incoming Reservation data is valid before processing. ASP.NET Core's built-in model validation can be leveraged to verify that all required fields are present and correctly formatted (e.g., valid email, phone number format).
- **Error Responses**: If the incoming data fails validation, the API should respond appropriately with error messages detailing what went wrong, typically returning a 400 Bad Request status.
