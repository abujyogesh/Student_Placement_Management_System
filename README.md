# Student Placement Management System

## Overview

The **Student Placement Management System** is a comprehensive solution designed to streamline and manage the placement activities of educational institutions. This system helps administrators, students, and recruiters coordinate the placement process efficiently, ensuring smooth communication and tracking of all placement-related activities.

## Features

- **Student Registration and Profile Management**: Students can register and manage their profiles, including academic records, skills, and personal information.
- **Placement Opportunities**: Recruiters can post job openings and internship opportunities, which are easily accessible to eligible students.
- **Application Management**: Students can apply for multiple opportunities, and the system tracks the status of each application.
- **Admin Dashboard**: Provides administrators with an overview of all placement activities, including student applications and placement results.

## Technologies Used

- **Frontend**: HTML, CSS, JavaScript
- **Backend**: C#.NET
- **Database**: MySQL
- **Version Control**: Git, GitHub
- **Other Tools**: Bootstrap

## Installation and Setup
Here's a "Run on Server" section tailored for a C# project:

---

## Run on Server

To run the **Student Placement Management System** on a server using C#, follow these steps:

### Prerequisites

- **Visual Studio** (2019 or later)
- **.NET Core SDK** (version 3.1 or later)
- **MySQL Server** (LocalDB or a full SQL Server installation)
- **IIS** (Internet Information Services) for deployment

### Step-by-Step Guide

1. **Clone the Repository:**

   First, clone the project repository from GitHub:

   ```bash
   git clone https://github.com/abujyogesh/Student_Placement_Mmanagement_System.git
   ```

2. **Open the Project in Visual Studio:**

   - Launch Visual Studio.
   - Select "Open a project or solution" and navigate to the folder where you cloned the repository.
   - Open the `.sln` (solution) file.

3. **Set Up the Database:**

   - Open MySQL.
   - Create a new database (e.g., `StudentPlacementDB`).
   - Run the SQL scripts located in the `Database` folder of the project to create tables and seed initial data.
   - Update the `connectionString` to match your SQL Server instance details.

4. **Restore NuGet Packages:**

   - In Visual Studio, right-click on the solution in the Solution Explorer and select "Restore NuGet Packages."
   - Ensure all dependencies are installed.

5. **Run the Application Locally:**

   - Press `F5` to build and run the application.
   - The application should open in your default web browser, running on `http://localhost:5000` (or the configured port).

6. **Deploy to IIS:**

   - Open the solution in Visual Studio.
   - Right-click on the project in Solution Explorer and select "Publish."
   - Choose "IIS, FTP, etc." and configure the publish settings.
   - Select a folder to publish the files to.
   - Open IIS Manager on your server.
   - Add a new website in IIS, pointing to the folder where you published the files.
   - Set the appropriate bindings (e.g., port 80 for HTTP).
   - Start the website in IIS.

7. **Access the Application:**

   - Once deployed, access the application by navigating to the server's IP address or domain name in your web browser.
   - Example: `http://your-server-ip` or `http://yourdomain.com`

## Contribution

Contributions are welcome! Please feel free to submit a pull request or open an issue for any feature suggestions, bug reports, or general improvements.
