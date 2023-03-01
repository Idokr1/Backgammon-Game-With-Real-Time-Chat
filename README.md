# Backgammon-Game-With-Chat
A web-based backgammon game that includes a chat feature. It was developed using React for the frontend, microservices written in C# using ASP.NET, and MongoDB as the database. The chat functionality was implemented using SignalR.

The project follows Clean Architecture principles, which means that the code is organized into layers that are independent of each other. This makes the code more maintainable, testable, and scalable.

## Installation
1. Clone the repository to your local machine
2. Change the database connection string inside the Server solution > DAL > Databases > MyMongoDB.cs to your connection string
3. Restore the NuGet packages
4. Install the client's dependencies by openning running the "npm install" command inside the client's directory using a terminal

## Run the Project:
1. Run the Server solution
2. Run the client using a terminal with "npm start" command
