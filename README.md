# CV Web Application (ASP.NET MVC - .NET Framework)

This project is a **CV (Curriculum Vitae) website application** developed using the **ASP.NET MVC Design Pattern**. It uses the **.NET Framework**, **Entity Framework (Database First)** approach, and **MS SQL Server**.

## 🔧 Technologies & Tools

- ASP.NET MVC (.NET Framework)
- Entity Framework (Database-First)
- Microsoft SQL Server
- HTML / CSS / Bootstrap
- jQuery
- Visual Studio
- IIS Express (or local server)

## 🧠 Key Features

- **Login & Logout:**  
  A secure login system allows administrators to access the backend.  
  No access is granted to the admin panel without authentication.

- **Admin Panel:**  
  The admin user can freely update all frontend content via the admin panel.  
  Editable sections include:  
  - About Me  
  - Education History  
  - Work Experience  
  - Skills  
  - Projects  
  - Contact Information

- **Frontend (Public UI):**  
  Visitors can view the CV information through a clean and responsive interface.

- **Database-First Architecture:**  
  The application connects to an existing SQL Server database. Models and context classes are generated via Entity Framework.

## 🔐 Authentication

- Built with **Forms Authentication**.
- Access is controlled using `[Authorize]` and `[AllowAnonymous]` attributes.
- Admin areas are restricted to authenticated users only.

## 🗃️ Database Structure

Main database tables include:

- TblAdmin  
- TblAbout  
- TblExperience  
- TblEducation  
- TblSkill  
- TblProject  
- TblContact  
- etc.
  
## 📁 Project Setup

1. Open the project with Visual Studio.
2. Update the `connectionString` in `Web.config` to match your SQL Server setup.
3. Restore NuGet packages if necessary (e.g., `EntityFramework`).
4. Press `Ctrl + F5` to run the application.


![image](https://github.com/user-attachments/assets/a0050166-2048-4358-b931-fe4b02f2b2a4)

![image](https://github.com/user-attachments/assets/50efd59d-d69a-4b91-bf2f-9479e0dd3441)

![image](https://github.com/user-attachments/assets/2f9d1c5a-87e3-494a-a951-390aff44ebcb)



