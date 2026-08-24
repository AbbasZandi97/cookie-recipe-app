# 🍪 Cookie Recipe App

A simple console-based cookie recipe builder built with C# and .NET 10.

## How to Use

1. Browse the list of available ingredients, each shown with an ID
2. Enter an ingredient's ID to add it to your recipe
3. Keep entering IDs to add more ingredients (duplicates are ignored)
4. Enter `q` to finish building your recipe
5. View the baking instructions generated for your chosen ingredients
6. Choose to save the recipe (Y/N) so it's loaded automatically next time

## Features

- Menu-driven ingredient selection — pick from 8 built-in ingredients by ID
- Duplicate-safe input — uses a `HashSet<int>` so repeated IDs don't count twice
- Per-ingredient instructions — each ingredient knows how it should be prepared
- Save & reload — recipes persist to disk and are loaded automatically on startup
- Swappable save formats — pluggable serializer interface, currently supports TXT and JSON
- Input validation — rejects out-of-range numbers, letters, and empty input

## Project Structure

```
Cookie-Recipe/
├── Cookie-Recipe.slnx
└── Cookie-Recipe/
    ├── Controllers/
    │   └── Service.cs              # App flow: load, collect input, print, save
    ├── Input/
    │   └── InputHandler.cs         # Reading and validating user input
    ├── Models/
    │   ├── Ingredient.cs           # Abstract base class for all ingredients
    │   ├── Butter.cs
    │   ├── Sugar.cs
    │   ├── WheatFlour.cs
    │   ├── CocoaPowder.cs
    │   ├── Cinnamon.cs
    │   ├── Chocolate.cs
    │   ├── Cardamom.cs
    │   └── CoconutFlour.cs
    ├── Persistence/
    │   ├── Format.cs                # Enum for supported save formats
    │   ├── ISerializer.cs           # Save/load contract
    │   ├── JsonIngredientSerializer.cs
    │   └── TxtSerializer.cs
    ├── Views/
    │   └── Printer.cs               # All console output
    └── Program.cs                   # Entry point
```

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Run the app

```bash
git clone https://github.com/AbbasZandi97/cookie-recipe-app.git
cd cookie-recipe-app/Cookie-Recipe/Cookie-Recipe
dotnet run
```

## Concepts Practiced

- **Object-Oriented Programming** — abstract `Ingredient` base class extended by 8 concrete ingredient classes
- **Interface-based design** — `ISerializer` contract with interchangeable `JsonIngredientSerializer` and `TxtSerializer` implementations
- **Separation of Concerns** — distinct layers for app logic (Controllers), data (Models), output (Views), input (Input), and storage (Persistence)
- **Encapsulation** — abstract methods force each ingredient to define its own instruction
- **Collections** — `HashSet<int>` to prevent duplicate ingredient selection
- **File I/O & Serialization** — reading/writing recipes with `System.Text.Json` and plain text files
- **Enums** — `Format` enum to select the active save format
- **Input Validation** — handling invalid, out-of-range, and empty user input gracefully
- **Nullable reference types** — explicit `string?` handling for console input
- **Namespaces & Project Structure** — organizing code into logical folders and namespaces
