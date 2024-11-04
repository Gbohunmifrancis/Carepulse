Carepulse Backend
Carepulse Backend is a RESTful API built with ASP.NET Core, designed to support a healthcare management application. This backend service provides authentication, appointment scheduling, and management of patients, doctors, and admins. The project includes role-based authentication for admin, doctors, and patients, with JWT tokens for secure access.

Table of Contents
Features
Technologies
Project Structure
Getting Started
Environment Variables
Database Setup
Running the Project
API Documentation
Contributing
Features
User Management: Register and manage users with different roles: Admin, Doctor, Patient.
Role-Based Authentication: Secure endpoints using JWT and role-based authorization.
Patient Records: Store and retrieve patient details.
Doctor and Appointment Management: Schedule, update, and delete appointments with detailed doctor-patient relationships.
Technologies
ASP.NET Core for building the RESTful API.
Entity Framework Core as the ORM for database operations.
JWT for secure authentication.
SQL Server as the default database.
Dependency Injection for service management.
Swagger for API documentation.
Project Structure
bash
Copy code
Carepulse_Backend
├── Controllers               # Contains API controllers for managing requests
├── Data                      # Contains database context and migrations
├── DTOs                      # Data Transfer Objects (DTOs) for requests and responses
├── Entities                  # Contains database models (e.g., User, Patient, Appointment)
├── Services                  # Business logic services (e.g., UserService, AppointmentService)
├── Services/Interfaces       # Service interfaces for Dependency Injection
├── Migrations                # Auto-generated database migrations
└── Program.cs                # Configures and starts the ASP.NET application
Getting Started
Prerequisites
Ensure you have the following installed:

.NET 6 SDK
SQL Server (or other database if configured)
Entity Framework CLI (for migrations)
Clone the Repository
bash
Copy code
git clone https://github.com/yourusername/carepulse-backend.git
cd carepulse-backend
Environment Variables
Create a appsettings.json file at the root of your project, if it doesn’t already exist, and configure the following environment variables.

json
Copy code
{
  "ConnectionStrings": {
    "DefaultConnection": "YourDatabaseConnectionString"
  },
  "JWT": {
    "SecretKey": "YourJWTSecretKey",
    "Issuer": "Carepulse",
    "Audience": "CarepulseUsers"
  }
}
DefaultConnection: Your database connection string (SQL Server or another database provider).
JWT SecretKey: A strong key for JWT encryption. (Use a 256-bit key for best security).
Database Setup
Ensure dotnet-ef CLI tool is installed.

bash
Copy code
dotnet tool install --global dotnet-ef
Add a migration to set up the database schema.

bash
Copy code
dotnet ef migrations add InitialCreate
Update the database to apply the migration.

bash
Copy code
dotnet ef database update
Running the Project
Start the application:

bash
Copy code
dotnet run
Access the API at https://localhost:5001/api.

Swagger is available at https://localhost:5001/swagger for API documentation and testing.

API Documentation
Swagger is used for documenting and testing the API.

Base URL: https://localhost:5001/api
Endpoints
Here are some of the key endpoints:
![image](https://github.com/user-attachments/assets/14420cac-d841-426b-9bea-777306ba9259)



Authentication
POST /api/auth/register - Register a new user.
POST /api/auth/login - Login and receive a JWT token.
Patients
GET /api/patients - Get all patients.
GET /api/patients/{id} - Get a patient by ID.
POST /api/patients - Create a new patient.
PUT /api/patients/{id} - Update an existing patient.
DELETE /api/patients/{id} - Delete a patient.
Appointments
GET /api/appointments - Get all appointments.
GET /api/appointments/{id} - Get an appointment by ID.
POST /api/appointments - Create a new appointment.
PUT /api/appointments/{id} - Update an existing appointment.
DELETE /api/appointments/{id} - Delete an appointment.
Testing the API
Using Postman
Download Postman and create a new collection.
Add your API endpoints to the collection.
Use the Authorization tab in Postman to include the JWT token in the headers for authenticated requests.
Running Unit Tests
The project includes unit tests for services and controllers. To run tests:

bash
Copy code
dotnet test
Contributing
Fork the project.
Create a new branch for your feature or bug fix.
Make your changes and commit them with descriptive messages.
Push your changes to your branch.
Open a Pull Request, describing what you've done.
License
This project is licensed under the MIT License.

Contact
For inquiries, please contact the project maintainer: Francis Gbohunmi.
