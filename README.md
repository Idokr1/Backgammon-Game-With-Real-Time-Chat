# Backgammon Game With Real-Time Chat
A web-based backgammon game that includes a chat feature. It was developed using React for the frontend, microservices written in C# using ASP.NET, and MongoDB as the database. The chat functionality was implemented using SignalR.

The project follows Clean Architecture principles, which means that the code is organized into layers that are independent of each other. This makes the code more maintainable, testable, and scalable.

## Installation
1. Clone the repository to your local machine
2. Change the database connection string inside the Server solution > DAL > Databases > MyMongoDB.cs to your connection string
3. Restore the NuGet packages
4. Install the client's dependencies by opening and running the "npm install" command inside the client's directory using a terminal

## Run the Project:
1. Run the Server solution
2. Run the client using a terminal with "npm start" command
3. Open the application in your browser: http://localhost:3000

## Usage
1. Create new accounts in different tabs
2. You can chat with the second account or play a backgammon game against him

## Built With
1. React
2. ASP.NET
3. MongoDB
4. SignalR

## Application
![App](/backgammongame.png)
