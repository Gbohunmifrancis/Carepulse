
---

# Carepulse Backend

Carepulse Backend is a RESTful API built with ASP.NET Core, designed to support a healthcare management application. This backend service provides authentication, appointment scheduling, and management of patients, doctors, and admins. The project includes role-based authentication for admin, doctors, and patients, with JWT tokens for secure access.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Environment Variables](#environment-variables)
- [Database Setup](#database-setup)
- [Running the Project](#running-the-project)
- [API Documentation](#api-documentation)
- [Contributing](#contributing)

---

## Features

- **User Management**: Register and manage users with different roles: Admin, Doctor, Patient.
- **Role-Based Authentication**: Secure endpoints using JWT and role-based authorization.
- **Patient Records**: Store and retrieve patient details.
- **Doctor and Appointment Management**: Schedule, update, and delete appointments with detailed doctor-patient relationships.

## Technologies

- **ASP.NET Core** for building the RESTful API.
- **Entity Framework Core** as the ORM for database operations.
- **JWT** for secure authentication.
- **SQL Server** as the default database.
- **Dependency Injection** for service management.
- **Swagger** for API documentation.

## Project Structure

```
Carepulse_Backend
├── Controllers               # Contains API controllers for managing requests
├── Data                      # Contains database context and migrations
├── DTOs                      # Data Transfer Objects (DTOs) for requests and responses
├── Entities                  # Contains database models (e.g., User, Patient, Appointment)
├── Services                  # Business logic services (e.g., UserService, AppointmentService)
├── Services/Interfaces       # Service interfaces for Dependency Injection
├── Migrations                # Auto-generated database migrations
└── Program.cs                # Configures and starts the ASP.NET application
```

---

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or other database if configured)
- [Entity Framework CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) (for migrations)

### Clone the Repository

```bash
git clone https://github.com/Gbohunmifrancis/carepulse-backend.git
cd carepulse-backend
```

---

## Environment Variables

Create a `appsettings.json` file at the root of your project, if it doesn’t already exist, and configure the following environment variables.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "xxx"
  },
  "JWT": {
    "SecretKey": "xxx",
    "Issuer": "Carepulse",
    "Audience": "CarepulseUsers"
  }
}
```

- **DefaultConnection**: Your database connection string (SQL Server or another database provider).
- **JWT SecretKey**: A strong key for JWT encryption. (Use a 256-bit key for best security).

---

## Database Setup

1. Ensure `dotnet-ef` CLI tool is installed.
    ```bash
    dotnet tool install --global dotnet-ef
    ```

2. Add a migration to set up the database schema.
    ```bash
    dotnet ef migrations add InitialCreate
    ```

3. Update the database to apply the migration.
    ```bash
    dotnet ef database update
    ```

---

## Running the Project

1. Start the application:
    ```bash
    dotnet run
    ```

2. Access the API at `https://localhost:5001/api`.

3. **Swagger** is available at `https://localhost:5001/swagger` for API documentation and testing.

---

## API Documentation

Swagger is used for documenting and testing the API.

- **Base URL**: `https://localhost:5001/api`

### Endpoints

Here are some of the key endpoints:

#### Authentication

- **POST** `/api/auth/register` - Register a new user.
- **POST** `/api/auth/login` - Login and receive a JWT token.
- ![image](https://github.com/user-attachments/assets/b51a9a8f-3022-42c1-8b45-310972c799ae)


#### Patients

- **GET** `/api/patients` - Get all patients.
- **GET** `/api/patients/{id}` - Get a patient by ID.
- **POST** `/api/patients` - Create a new patient.
- **PUT** `/api/patients/{id}` - Update an existing patient.
- **DELETE** `/api/patients/{id}` - Delete a patient.

#### Appointments

- **GET** `/api/appointments` - Get all appointments.
- **GET** `/api/appointments/{id}` - Get an appointment by ID.
- **POST** `/api/appointments` - Create a new appointment.
- **PUT** `/api/appointments/{id}` - Update an existing appointment.
- **DELETE** `/api/appointments/{id}` - Delete an appointment.

---

## Testing the API

### Using Postman

1. [Download Postman](https://www.postman.com/downloads/) and create a new collection.
2. Add your API endpoints to the collection.
3. Use the **Authorization** tab in Postman to include the JWT token in the headers for authenticated requests.

### Running Unit Tests

The project includes unit tests for services and controllers. To run tests:

```bash
dotnet test
```

---

## Contributing

1. Fork the project.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them with descriptive messages.
4. Push your changes to your branch.
5. Open a Pull Request, describing what you've done.

---

## License

This project is licensed under the MIT License.

---

## Contact

For inquiries, please contact the project maintainer: **Francis Gbohunmi**.

---

![swaggerforbackend](https://github.com/user-attachments/assets/44456678-d9d6-42a4-8a73-1b2dbc7b71bc)
