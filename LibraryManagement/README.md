# LibraryManagement (VB.NET Class Library + WinForms UI)

A Visual Basic .NET class library targeting .NET Framework 4.8 that includes Windows Forms UI, MariaDB data access (via MySql.Data), and utilities for a simple Library Management System.

## Features
- Models for Books, Members, Transactions with validation and INotifyPropertyChanged
- Data access using parameterized queries with CRUD operations
- Utilities: Logger, CSV Exporter, ValidationHelper, ConfigManager
- Windows Forms: Main dashboard, Data entry, Search, Settings
- Data binding to grids, search/filter, CSV export
- High-contrast, accessible UI with keyboard navigation

## Requirements
- Visual Studio 2019 or later with .NET Framework 4.8 targeting pack
- MariaDB 10.4+ (or MySQL 8, but schema targets MariaDB)

## Setup
1. Open the solution:
   - Create a new blank solution or open Visual Studio
   - Add an existing project and select `LibraryManagement/LibraryManagement.vbproj`

2. Restore NuGet packages:
   - Visual Studio should restore `MySql.Data` automatically on build. If not, use:
     - Tools > NuGet Package Manager > Manage NuGet Packages for Solution…
     - Search `MySql.Data` and install version `8.4.0`

3. Configure database connection:
   - Edit `App.config` values or use the Settings form at runtime:
     - `DbHost`: default `localhost`
     - `DbPort`: default `3306`
     - `DbUser`: default `root`
     - `DbPassword`: default `password`
     - `DbName`: default `library_db`

4. Create schema:
   - Run the SQL in `Database/schema.sql` against your MariaDB instance.

5. Run UI (if using as WinForms host):
   - This project is a Class Library but includes Forms for reuse from a host app.
   - Create a WinForms executable project targeting .NET Framework 4.8.
   - Add a reference to this Library project.
   - In Program.vb of the host app, start with:
     ```vb
     <STAThread>
     Sub Main()
         Application.EnableVisualStyles()
         Application.SetCompatibleTextRenderingDefault(False)
         Application.Run(New LibraryManagement.Forms.MainForm())
     End Sub
     ```

## Notes
- Parameterized queries used throughout to prevent SQL injection.
- Exceptions are caught, logged, and surfaced via MessageBox where appropriate.
- CSV export uses UTF-8 with BOM for Excel compatibility.

## Sample Entities
- Books: `BookID, Title, Author, ISBN, PublishYear, Genre, Available`
- Members: `MemberID, FirstName, LastName, Email, Phone, JoinDate`
- Transactions: `TransactionID, BookID, MemberID, BorrowDate, ReturnDate, Status`
