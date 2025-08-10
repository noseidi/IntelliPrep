IntelliPrep

A full-stack ASP.NET Core + Angular application for managing and practicing questions, topics, and tests.
📌 Features

    ASP.NET Core Web API backend

    Angular frontend application

    Entity Framework Core with SQL Server

    CRUD operations for Questions, Topics, and Tests

    REST API with JSON responses

    Fully responsive Angular UI

🛠 Tech Stack

    Backend: ASP.NET Core 8.0, C#, EF Core

    Frontend: Angular 17+, TypeScript, HTML, SCSS

    Database: SQL Server LocalDB

    Tools: Visual Studio, VS Code, Git

📂 Project Structure

IntelliPrep/
│
├── IntelliPrep.API        # Backend ASP.NET Core Web API
├── IntelliPrep.Core       # Shared core logic and models
└── intelliprep.frontend   # Angular frontend

🚀 Getting Started
1️⃣ Clone the repository

git clone https://github.com/noseidi/IntelliPrep.git
cd IntelliPrep

2️⃣ Backend Setup (ASP.NET Core API)

    Navigate to the API project folder:

cd IntelliPrep.API

Install dependencies:

dotnet restore

Apply EF Core migrations & update database:

dotnet ef database update -p IntelliPrep.API -s IntelliPrep.API

Run the backend:

dotnet run

API will be available at:

    https://localhost:5001

3️⃣ Frontend Setup (Angular)

    Navigate to the Angular project:

cd ../intelliprep.frontend

Install dependencies:

npm install

Run the Angular app:

ng serve

Frontend will be available at:

    http://localhost:4200

📡 API Endpoints
Method	Endpoint	Description
GET	/api/Questions	Get all questions
POST	/api/Questions	Add new question
GET	/api/Topics	Get all topics
POST	/api/Tests	Create new test
📷 Screenshots (Optional)

Add screenshots of your app UI here.
📜 License

This project is licensed under the MIT License – free to use and modify.
