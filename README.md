Welcome to the TodoList Application, a project developed using the robust C# ASP.NET Core framework. 
This application provides a powerful platform for managing tasks, leveraging a collection of REST APIs 
designed to enhance task organization and management.

Features
APIs for Efficient Task Management:
The application is equipped with RESTful APIs that empower users to seamlessly create new todo 
lists, delete existing ones, add items to existing todo lists, or remove items as needed.

Utilization of Entity Framework Core:
The project integrates Entity Framework Core as an object-relational mapping (ORM) tool. This 
strategic integration simplifies database interactions, streamlining data manipulation operations.

MySQL Database Integration: 
For robust and efficient data storage, the application employs the MySQL relational database.
This choice ensures data integrity and scalability, enhancing the overall application performance.

Seamless Asynchronous Programming: 
The application's architecture embraces modern asynchronous programming principles by employing
async and await patterns. This approach ensures optimal responsiveness and scalability,
enabling the application to handle numerous requests concurrently.

Thoughtful API Design: 
The APIs have been meticulously crafted to provide an intuitive and user-friendly experience.The 
endpoints are logically structured, simplifying usage for developers who integrate or extend the application.

Cascade Behavior for Data Consistency: 
The application is designed with data integrity in mind. Whenever a todo list is deleted, 
the associated items are automatically removed from the database. This cascade behavior 
ensures a consistent and accurate representation of tasks within the application.
