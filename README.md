# Expense Tracker API
The Expense Tracker API is a RESTful web service built using ASP.NET Core. It provides endpoints for managing expenses, incomes, categories, and users. The API includes JWT authentication for securing endpoints and Swagger UI for easy API documentation and testing.

# Table of Contents
Features
Getting Started
Prerequisites
Installation
Configuration
Usage
Endpoints
Authentication
Deployment
Built With
License

# Features
Expense Management: CRUD operations for managing expenses.
Income Management: CRUD operations for managing incomes.
Category Management: CRUD operations for managing categories.
User Management: CRUD operations for managing users.
JWT Authentication: Secure API endpoints using JWT tokens.
Swagger UI: Interactive API documentation for easy testing.

# Getting Started
Prerequisites
Before running the Expense Tracker API, ensure you have the following installed:

.NET 5 SDK
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/your-username/expense-tracker-api.git
Navigate to the project directory:

bash
Copy code
cd expense-tracker-api
Run the application:

bash
Copy code
dotnet run
Configuration
Update the appsettings.json file with your database connection string and JWT secret key. You can find the file in the ExpenseTrackerAPI project folder.

# Usage
Once the API is running, you can access the Swagger UI at https://localhost:5001/swagger to explore and test the available endpoints.

# Endpoints
The Expense Tracker API exposes the following endpoints:

/api/expenses: CRUD operations for expenses.
/api/incomes: CRUD operations for incomes.
/api/categories: CRUD operations for categories.
/api/users: CRUD operations for users.
For detailed information on each endpoint, refer to the Swagger UI documentation.

# Authentication
The Expense Tracker API uses JWT authentication. To authenticate requests, include a valid JWT token in the Authorization header of your HTTP requests. You can obtain a JWT token by sending a POST request to the /api/users/authenticate endpoint with valid user credentials.

# Deployment
For deployment, you can publish the API to a hosting provider or deploy it to a server using tools like Docker. Make sure to configure the necessary environment variables for database connection and JWT secret key in your deployment environment.

# Built With
ASP.NET Core - Web framework
Entity Framework Core - ORM for database access
Swagger - API documentation
JWT - Authentication mechanism

#License
This project is licensed under the MIT License - see the LICENSE file for details.