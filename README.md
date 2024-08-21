# AnyRoom - Hotel Reservation

This project is an educational simulation of a hotel reservation network. It demonstrates the integration of a React frontend, a .NET backend, and PostgreSQL for data storage. The aim of this project is to explore and practice the implementation of a full-stack application, leveraging modern technologies and best practices.

## Table of Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Running the Application](#running-the-application)
- [Database Setup](#database-setup)
- [License](#license)

## Overview

This application allows users to browse available hotels, make reservations, and manage their bookings. It features a user-friendly interface built with React, and a robust backend developed in .NET to handle business logic and database operations. PostgreSQL is used as the database to securely store user and booking data.

## Technologies Used

- **Frontend**: React
- **Backend**: .NET Core
- **Database**: PostgreSQL
- **Tools**: pgAdmin 4, Visual Studio Code, Visual Studio 2022, Postman

## Installation

### Prerequisites

Before running the application, ensure you have the following installed:

- Node.js and npm
- .NET SDK
- PostgreSQL
- pgAdmin 4

### Clone the Repository

```bash
git clone https://github.com/diegowfc/do-you-have-a-room
cd hotel-reservation-network

# Frontend
cd client
npm install

# Backend
cd server
dotnet restore

 ```

## Running the application
```bash
cd server
dotnet run

cd client
npm start

```
## Database Setup
Setting Up PostgreSQL
Open pgAdmin 4 and create a new database named dbanyroom.

Import the provided database.sql file to set up the database schema and seed data. Note that the database.sql file is included for context and educational purposes. It contains the basic structure of the database to help you get started quickly.

Configure the database connection string in the .NET backend project to match your PostgreSQL setup. You can find this in the appsettings.json file under the ConnectionStrings section.

Importing database.sql
In pgAdmin 4, right-click on the hotel_reservation database.
Select Restore....
Choose the database.sql file and click Restore.

## License
This project is licensed under the MIT License. See the LICENSE file for more information.
