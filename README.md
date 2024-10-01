# TeamTasker

**TeamTasker** is a task tracker web application built using **.NET** and **React**, designed to simplify task scheduling and task assignment within teams. It consolidates task management into a single platform, solving the need for multiple services just for task assignment.

## Table of Contents

- [Features](#features)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Technologies](#technologies)
- [License](#license)
- [Contact](#contact)

## Features

- **Task Scheduling**: Schedule tasks for yourself.
- **Team Task Assignment**: Assign tasks to your team members.
- **Integrated Solution**: One platform for task management, removing the need for multiple services.

## Project Structure

The project is organized into the following components:

- **TeamTasker.API**: The backend project built with **ASP.NET Core** for managing the application’s logic and API endpoints.
- **TeamTasker.Client**: The frontend project built with **React.js** for the user interface.
- **TeamTasker.Data**: Contains the **MySQL** database models and data access logic.

## Installation

Follow these steps to set up and run the project on your local machine:

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (for React)
- [MySQL](https://www.mysql.com/downloads/) (Database)

### Steps

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/TeamTasker.git
   cd TeamTasker
   ```

2. **Database Setup** (TeamTasker.Data):

   - Configure the MySQL connection string in the `TeamTasker.Data` project.
   - Apply the database migrations or set up the schema using the `.sql` scripts or entity framework migration (if applicable).

3. **Backend Setup (TeamTasker.API)**:

   - Navigate to the `TeamTasker.API` folder:
     ```bash
     cd TeamTasker.API
     ```
   - Restore the .NET packages:
     ```bash
     dotnet restore
     ```
   - Update the `appsettings.json` file with your MySQL connection details.
   - Build the project:
     ```bash
     dotnet build
     ```
   - Run the API:
     ```bash
     dotnet run
     ```

4. **Frontend Setup (TeamTasker.Client)**:
   - Navigate to the `TeamTasker.Client` folder:
     ```bash
     cd TeamTasker.Client
     ```
   - Install the required npm packages:
     ```bash
     npm install
     ```
   - Run the React app:
     ```bash
     npm start
     ```
   - The application will run on `http://localhost:3000`.

## Usage

Once the application is running:

1. **Access the Frontend**: Open `http://localhost:3000` in your browser.
2. **Create and Manage Tasks**: Schedule tasks for yourself or assign tasks to team members.
3. **Monitor Progress**: Keep track of ongoing tasks and their completion status.

## Technologies

TeamTasker is built using the following technologies:

- **Backend**: ASP.NET Core (TeamTasker.API)
- **Frontend**: React.js (TeamTasker.Client)
- **Database**: MySQL (TeamTasker.Data)

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for more details.

## Contact

For any inquiries or feedback, feel free to reach out via email: `donycastro80@gmail.com`.

---
