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

## 📄 Sample Admin Credentials

```text
Username: admin  
Password: 1234

![image](https://github.com/user-attachments/assets/af4577df-d7a8-4476-850e-bc2f203ff724)

![image](https://github.com/user-attachments/assets/66b145b5-97f5-4660-9e36-cee6b608c132)
![image](https://github.com/user-attachments/assets/b9bb99c1-983e-45c6-9aa3-b84300260a2e)
