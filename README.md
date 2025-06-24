# .NET Exercises Collection

Welcome to the **.NET Exercises Collection** monorepo, consolidating a series of C# practice projects and assignments drawn from Kodluyoruz and Patika courses. Each folder contains an individual project with its own README, source code, and full Git history.

---

## Projects Overview

| Folder                                | Description                                                                                        |
| ------------------------------------- | -------------------------------------------------------------------------------------------------- |
| **kodluyoruzilkrepo/**                | Starter repo from Kodluyoruz demonstrating basic Git/GitHub workflows and a simple C# Hello World. |
| **patika\_degisken\_odevi/**          | Patika variable assignment lab covering data types, arithmetic operations, and console I/O.        |
| **patika\_degisken\_odevi\_2/**       | Follow-up Patika exercise on string manipulation and formatted console output.                     |
| **patika\_c-\_101\_odevleri\_total/** | Consolidated collection of Patika’s C# 101 assignments on control flow, methods, and arrays.       |
| **c-101\_telefone\_rehber/**          | In-memory phonebook console app implementing CRUD operations and search by name.                   |
| **csharp\_to\_do\_proje/**            | To-do list application illustrating CRUD workflows and JSON file persistence.                      |
| **csharp\_example\_projects/**        | Assortment of small .NET demos: file handling, WinForms GUI, and a simple ASP.NET Core Web API.    |
| **patika\_Linq\_Exercise/**           | LINQ query exercises covering filtering, projection, grouping, and aggregation on collections.     |
| **patika\_middleware\_practice/**     | ASP.NET Core middleware exercises for custom logging, error handling, and header manipulation.     |
| **patika\_bookstore/**                | Simple ASP.NET Core Bookstore Web API with RESTful CRUD endpoints and EF Core integration.         |

---

## Getting Started

1. **Clone the repository**

   ```bash
   git clone git@github.com:emrebasaranCE/dotnet-exercises.git
   cd dotnet-exercises
   ```

2. **Browse a project**

   ```bash
   cd kodluyoruzilkrepo          # or any other folder listed above
   cat README.md                 # see project-specific instructions
   dotnet run --project *.csproj # build & run
   ```

3. **Explore and learn**

   * Each folder is self-contained; feel free to run, modify, and experiment.
   * Consult individual READMEs for detailed setup and usage.

---

## Contributing

If you’d like to add another project:

```bash
# from the monorepo root
git remote add newproj <repo-url>
git fetch newproj
git subtree add --prefix=<new-folder>/ newproj <branch>
git remote remove newproj
```

Then add a row above in the Projects Overview table.

---
