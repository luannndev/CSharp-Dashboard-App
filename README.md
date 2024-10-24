
# Advanced C# Desktop Application 🖥️

This is an advanced C# desktop application built using Windows Forms and demonstrates several important features such as database integration, logging, configuration management, and API calls. The project is designed for learning purposes and showcases how different components can be combined to create a fully functional desktop application.

## Features ✨

- **User Interface (UI)**: Built with Windows Forms to provide a user-friendly interface.
- **Database Integration**: Uses SQLite for CRUD (Create, Read, Update, Delete) operations.
- **Logging**: Implemented with a logging system that writes logs to a file.
- **Configuration Settings**: Managed through a config file (AppSettings).
- **API Integration**: Calls a public API to fetch weather data.
- **File Operations**: Reads and writes data from/to files.
- **Unit Tests**: Includes tests for business logic using xUnit.

## Project Structure 📁

- **/src**: Contains all the source code for the application.
  - `MainForm.cs`: The main UI and logic for the application.
  - `DatabaseHelper.cs`: Handles database operations.
  - `Logger.cs`: Handles logging to a file.
  - `AppSettings.cs`: Handles application configuration.
  - `WeatherAPI.cs`: Handles API calls for weather data.
  - `FileOperations.cs`: Handles reading and writing to files.
- **/tests**: Contains unit tests for the business logic.
  - `BusinessLogicTests.cs`: Unit tests using xUnit.
- **/data**: Contains the SQLite database file.
- **/logs**: Contains application log files.
- **/config**: Contains the configuration files (e.g., AppSettings.json).

## Prerequisites 🛠️

- **.NET 5.0 SDK**: Ensure that you have .NET 5.0 installed on your machine.
- **SQLite**: No installation required; the SQLite database is included in the project.
- **Visual Studio**: You will need Visual Studio to run and build this project.

## How to Run the Project 🚀

1. **Clone the repository**:
   ```bash
   [git clone https://github.com/luannndev/CSharp-Dashboard-App.git
   ```
   
2. **Open the project**:
   Open the project in Visual Studio.

3. **Build the solution**:
   In Visual Studio, go to `Build > Build Solution` to compile the code.

4. **Run the application**:
   Press `F5` or go to `Debug > Start Debugging`.

## Features Breakdown 🔍

### 1. User Interface (UI)
The UI is built using Windows Forms and contains several buttons, text fields, and menus. It allows the user to perform various actions such as database operations, API calls, and file reading/writing.

### 2. Database Integration
The application integrates SQLite to store user data. It demonstrates CRUD operations:
- Create: Insert new data into the database.
- Read: Display data from the database in the UI.
- Update: Modify existing data.
- Delete: Remove data from the database.

The `DatabaseHelper.cs` file manages the connection and operations with the SQLite database.

### 3. Logging
All important actions are logged to a file, allowing you to track the application's behavior and errors. The log files are stored in the `/logs` directory, and the `Logger.cs` file is responsible for writing to the log.

### 4. Configuration Management
Application settings such as API keys, database connection strings, and other configurations are managed through a config file (`AppSettings.json`). The `AppSettings.cs` file reads these settings and provides access to the rest of the application.

### 5. API Integration
The application fetches weather data from a public API (e.g., OpenWeatherMap). The `WeatherAPI.cs` file makes the API call and displays the weather information in the UI.

### 6. File Operations
The app allows users to read from and write to files. It can open a text file, display its content, and save modifications back to the file. This is managed by the `FileOperations.cs` class.

### 7. Unit Tests
The project includes unit tests for the business logic using xUnit. The tests ensure that core functionality like database operations and file handling works correctly. These tests can be run from within Visual Studio or the command line.

## Unit Tests 🧪

You can run the unit tests with the following command:

```bash
dotnet test
```

The tests are located in the `/tests` directory and cover the core business logic of the application.

## License 📜

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing 🤝

Feel free to fork this repository and make changes. If you have any feature requests or bug reports, please open an issue or submit a pull request.

Happy coding! 😊
