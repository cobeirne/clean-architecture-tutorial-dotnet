# Clean.Architecture.Tutorial

## Description

**Clean.Architecture.Tutorial** is a practical example of how to implement **Clean Architecture** principles within a modern **.NET 8 Web API** solution.  
The purpose of this project is to demonstrate how to structure enterprise-grade .NET applications in a way that promotes **separation of concerns**, **testability**, and **maintainability**.  

This tutorial provides a reference implementation for teams seeking to organize their application into clearly defined layers — **Domain**, **Application**, **Infrastructure**, and **Presentation (API)** — while keeping dependencies flowing inwards.

---

## Table of Contents
- [Architecture Overview](#architecture-overview)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

---

## Architecture Overview

The solution is based on **Clean Architecture**, popularized by Robert C. Martin (Uncle Bob).  
Each layer has a distinct purpose and dependency direction:


### Layers Explained

- **Domain**: Core business logic and entities. Contains enterprise-wide rules and models, independent of frameworks.  
- **Application**: Coordinates domain logic using use cases, interfaces, and service definitions. Depends only on Domain.  
- **Infrastructure**: Implements external concerns such as database access, APIs, and file systems. Depends on both Domain and Application.  
- **Presentation**: The entry point that handles HTTP requests, exposes endpoints, and invokes Application services. Depends on Domian, Application and Infrastruture.

---

## Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/cobeirne/clean-architecture-tutorial-dotnet.git
   ```

2. **Navigate to the solution directory**
   ```bash
   cd Clean.Architecture.Tutorial
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Build the solution**
   ```bash
   dotnet build
   ```

---

## Usage

To run the Web API:
```bash
dotnet run --project src/Clean.Architecture.Tutorial.WebAPI
```

Once running, navigate to:
```
http://localhost:5139/swagger/index.html
```

You’ll find a pre-configured **Swagger UI** with sample endpoints demonstrating basic CRUD operations implemented through the clean architecture layers.

---

## Project Structure

```
Clean.Architecture.Tutorial/
│
├── src/
│   ├── Clean.Architecture.Tutorial.Core/               # Core entities, enums, interfaces
│   ├── Clean.Architecture.Tutorial.Application/        # Use cases, DTOs, interfaces
│   ├── Clean.Architecture.Tutorial.Infrastructure/     # Data access, persistence, third-party services
│   └── Clean.Architecture.Tutorial.WebAPI/             # ASP.NET Core Web API project
│
├── tests/
│   ├── Clean.Architecture.Tutorial.WebAPI.UnitTests/           # Domain and Application unit tests
│   └── Clean.Architecture.Tutorial.WebAPI.IntegrationTests/    # API and Infrastructure integration tests
│
└── README.md
```

---

## Notes

- Projects target .NET 8 (net8.0).

---

## License

This project is licensed under the **MIT License**.  
See the [LICENSE](LICENSE) file for details.

---

## Acknowledgements

- [Clean Architecture by Robert C. Martin](https://blog.cleancoder.com/) — the foundation of this pattern
- Kent, G. H. (2025). C# 10 clean architecture with .NET 6: Mastering the art of building scalable and maintainable applications with Entity Framework Core and MediatR [Kindle edition]. Independently published.
