# 🏃‍♂️ Running Club - ASP.NET Core MVC Web App

A full-featured web application for a local running club built with ASP.NET Core MVC and .NET 6. This project serves as a practical case study demonstrating modern web development principles with the .NET ecosystem.

This application allows users to find and join running clubs, view upcoming races and events, and connect with other runners.


---

## ✨ Features

* **Club Management:** Browse, create, edit, and delete running clubs.
* **Event Management:** View, create, edit, and delete running events or races associated with clubs.
* **User Authentication:** Secure user registration and login system using ASP.NET Core Identity.
* **Dashboard:** A personalized dashboard for logged-in users to see their clubs and events.
* **Cloud Image Storage:** Integration with Cloudinary for uploading and managing club and event images.
* **MVC Architecture:** A clean and maintainable codebase following the Model-View-Controller (MVC) design pattern.

---

## 🛠️ Tech Stack & Tools

This project was built using the following technologies:

* **Backend:**
    * ![.NET](https://img.shields.io/badge/.NET-6-512BD4?style=for-the-badge&logo=dotnet)
    * ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge)
    * ![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-6-512BD4?style=for-the-badge)
* **Database:**
    * ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server)
* **Frontend:**
    * ![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
    * ![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
    * ![Bootstrap](https://img.shields.io/badge/Bootstrap-5.2-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
* **Third-Party Services:**
    * ![Cloudinary](https://img.shields.io/badge/Cloudinary-3448C5?style=for-the-badge&logo=cloudinary&logoColor=white) - For cloud-based image management.

---

## 🚀 Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

You need to have the following software installed:
* [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other compatible database)
* A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).

### Installation

1.  **Clone the repository**
    ```sh
    git clone ![https://github.com/syakil/runningClub.git](https://github.com/syakil/runningClub.git)
    ```

2.  **Navigate to the project directory**
    ```sh
    cd runningClube
    ```

3.  **Configure your settings**
    * Rename `appsettings.Development.json.example` to `appsettings.Development.json`.
    * Inside `appsettings.Development.json`, update the `DefaultConnection` with your SQL Server connection string.
  
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=RunGroopWebApp;Trusted_Connection=True;..."
    },
    "CloudinarySettings": {
      "CloudName": "your-cloud-name",
      "ApiKey": "your-api-key",
      "ApiSecret": "your-api-secret"
    }
    ```

4.  **Restore dependencies**
    ```sh
    dotnet restore
    ```

5.  **Apply database migrations**
    This command will create the database and its tables based on the Entity Framework models.
    ```sh
    dotnet ef database update
    ```

6.  **Run the application**
    ```sh
    dotnet run
    ```
    The application will be available at `https://localhost:5001` or `http://localhost:5000` in your browser.

---

## 🙏 Acknowledgements

This project was built as a learning exercise by following the "Learn ASP.NET Core MVC" tutorial series. A huge thank you to the creator for the excellent and informative content.

* [Link to the YouTube Playlist or Course](https://www.youtube.com/playlist?list=PL82C6-O4XrHde_urqhKJHH-HTUfTK6siOhttps://www.youtube.com/playlist?list=PL82C6-O4XrHde_urqhKJHH-HTUfTK6siO)