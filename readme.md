# DesignPatterns (C#)

This repository is a .NET 6 console application that demonstrates these design patterns:

- Builder
- Simple Factory
- Factory Method
- Abstract Factory

## Project structure

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns.sln`  
  Visual Studio solution that contains the `DesignPatterns` console project.

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns.csproj`  
  Project configuration:
  - `TargetFramework` = `net6.0`
  - `OutputType` = `Exe`
  - `ImplicitUsings` and nullable reference context enabled.

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/Program.cs`  
  Application entry point. It:
  1. Prints a startup banner.
  2. Runs `BuilderTest.TestBuilderexample()`.
  3. Runs `FactoryTest.TestSimpleFactory()`.
  4. Runs `FactoryTest.TestFactoryMethod()`.
  5. Runs `FactoryTest.TestAbstractFactory()`.

---

## Builder pattern code

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Builder/Computer.cs`
Represents the product being built.

- Properties:
  - `Ram` (required)
  - `HddSize` (required)
  - `keyboard` (optional)
  - `mouse` (optional)
  - `touchscreen` (optional)
- Constructor enforces required values (`memory`, `harddisk`).
- `ToString()` prints the full configuration.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Builder/ComputerBuilder.cs`
Builds `Computer` step-by-step with chainable methods.

- Holds a private `Computer systemb` instance.
- Constructor sets required base specs.
- Optional fluent methods:
  - `AddKeyboard(string keyboard)`
  - `AddMouse(string mouse)`
  - `AddTouchscreen(string touchscreen)`
- `Build()` returns the configured `Computer`.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Builder/BuilderTest.cs`
Demonstrates how the builder is used.

- Creates a **Laptop** with RAM + HDD + touchscreen.
- Creates a **Desktop** with RAM + HDD + keyboard + mouse.
- Prints both results.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Builder/Details.txt`
Support file in the Builder folder (not used by runtime code).

---

## Factory pattern shared contract

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/Common/IPizza.cs`
Common interface for all pizza variants.

- `void makePizza();` is the operation every concrete pizza implements.

---

## Simple Factory code

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/SimpleFactory/ChickenPizza.cs`
Concrete `IPizza` implementation that prints `"Chicken Pizza Ready"`.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/SimpleFactory/MushroomPizza.cs`
Concrete `IPizza` implementation that prints `"Mushroom Pizza Ready"`.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/SimpleFactory/PizzaFactory.cs`
Simple Factory creator.

- `MakePizza(string PizzaType)` chooses concrete class using `switch`:
  - `"Chicken"` -> `ChickenPizza`
  - `"Mushroom"` -> `MushroomPizza`
  - otherwise returns `null`
- Calls `makePizza()` before returning the created pizza.

---

## Factory Method code

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/Factory Method/PizzaFactoryMethod.cs`
Abstract creator defining the factory method workflow.

- `MakePizza()`:
  1. Calls abstract `createPizza()`.
  2. Calls `makePizza()` on the returned product.
  3. Returns the product.
- `createPizza()` is overridden by subclasses.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/Factory Method/ChickenPizzaFactory.cs`
Concrete factory method class. `createPizza()` returns `ChickenPizza`.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/Factory Method/MushroomPizzaFactory.cs`
Concrete factory method class. `createPizza()` returns `MushroomPizza`.

---

## Abstract Factory code

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/PizzaCompanyAbstractFactory.cs`
Abstract factory that defines a family of products:

- `MakeChickenPizza()`
- `MakeMushroomPizza()`

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/DominosPizzaCompany.cs`
Concrete factory for Dominos family.

- `MakeChickenPizza()` creates `DominosChickenPizza`.
- `MakeMushroomPizza()` creates `DominosMushroomPizza`.
- Each method calls `makePizza()` before returning.

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/PizzaHutPizzaCompany.cs`
Concrete factory for Pizza Hut family.

- `MakeChickenPizza()` creates `PizzaHutChickenPizza`.
- `MakeMushroomPizza()` creates `PizzaHutMushroomPizza`.
- Each method calls `makePizza()` before returning.

### Pizza implementations used by abstract factory

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/DominosChickenPizza.cs`  
  Prints `"Dominos Chicken Pizza Ready"`.

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/DominosMushroomPizza.cs`  
  Prints `"Dominos Mushroom Pizza Ready"`.

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/PizzaHutChickenPizza.cs`  
  Prints `"Pizza Hut Chicken Pizza Ready"`.

- `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/AbstractFactory/PizzaHutMushroomPizza.cs`  
  Prints `"Pizza Hut Mushroom Pizza Ready"`.

---

## Pattern demo runner for all factory variants

### `/home/runner/work/DesignPatterns/DesignPatterns/DesignPatterns/DesignPatterns/Factories/FactoryTest.cs`
Contains three demo methods:

- `TestSimpleFactory()` calls `PizzaFactory.MakePizza(...)` for two types.
- `TestFactoryMethod()` uses `ChickenPizzaFactory` and `MushroomPizzaFactory` polymorphically.
- `TestAbstractFactory()` creates `DominosPizzaCompany` and `PizzaHutPizzaCompany` and requests both pizza families from each.

---

## Build and run

From `/home/runner/work/DesignPatterns/DesignPatterns`:

```bash
dotnet build DesignPatterns.sln
dotnet run --project DesignPatterns/DesignPatterns.csproj
```

The console output shows each design pattern section and the created object/product messages.
