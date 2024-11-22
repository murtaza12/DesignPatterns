# Design Patterns in C#

## Overview
This repository provides examples of commonly used design patterns in software development, implemented in C#. Each pattern is organized into its own folder with a `README.md` file explaining its purpose, structure, and usage. This project is intended to serve as a learning resource and a quick reference for developers.

## Technology Stack

- **Programming Language**: C# (Version 12)
- **Framework**: .NET 8
- **Unit Testing Framework**: xUnit
- **Dependency Injection**: Built-in DI in .NET
- **IDE**: Visual Studio 2022 (or any compatible C# IDE)
- **Version Control**: Git
- **UML Diagrams**: Generated using PlantUML or any UML tool
- **Operating System**: Cross-platform support (Windows, macOS, Linux)

## Repository Structure
Each folder represents a design pattern and includes:
- **Code Implementation**: A C# example of the pattern.
- **README.md**: Explanation of the pattern, including purpose, structure, and real-world usage.
- **UML Diagrams** (if applicable): Diagrams illustrating the structure and relationships in the pattern.

## How to Use This Repository
1. **Clone the Repository**: Clone this repository to your local machine.
2. **Browse the Patterns**: Explore each design pattern folder to understand its implementation.
3. **Run Examples**: Open the solution in your favorite IDE (e.g., Visual Studio) to run and test each pattern.

## Design Patterns

### 1. Creational Patterns
Creational patterns focus on how objects are created. These patterns ensure flexibility and reuse in the instantiation process.

- **Abstract Factory**: Creates an instance of several families of classes without specifying their concrete classes.
- **Builder**: Separates the construction of a complex object from its representation.
- **Factory Method**: Defines an interface for creating an object, but allows subclasses to alter the type of created object.
- **Prototype**: Clones an existing object rather than creating a new one from scratch.
- **Singleton**: Ensures a class has only one instance and provides a global point of access to it.

### 2. Structural Patterns
Structural patterns deal with the composition of classes or objects. They help ensure that different components work together seamlessly.

- **Adapter**: Allows incompatible interfaces to work together by creating a bridge between them.
- **Bridge**: Decouples an abstraction from its implementation, allowing the two to vary independently.
- **Composite**: Treats individual objects and compositions of objects uniformly.
- **Decorator**: Adds responsibilities to objects dynamically.
- **Facade**: Provides a simplified interface to a complex subsystem.
- **Flyweight**: Minimizes memory usage by sharing as much data as possible with similar objects.
- **Proxy**: Provides a surrogate or placeholder for another object to control access to it.

### 3. Behavioral Patterns
Behavioral patterns focus on how classes and objects communicate and interact with each other.

- **Chain of Responsibility**: Passes a request along a chain of handlers until one handles it.
- **Command**: Encapsulates a request as an object, allowing parameterization of clients with different requests.
- **Interpreter**: Defines a representation for a language’s grammar and an interpreter to interpret sentences in the language.
- **Iterator**: Provides a way to access elements of a collection sequentially without exposing its underlying structure.
- **Mediator**: Reduces the direct communication between objects by introducing a mediator object.
- **Memento**: Saves and restores the state of an object without violating encapsulation.
- **Observer**: Allows an object to notify other objects when its state changes.
- **State**: Allows an object to change its behavior when its internal state changes.
- **Strategy**: Enables selecting an algorithm at runtime.
- **Template Method**: Defines the skeleton of an algorithm, with specific steps redefined by subclasses.
- **Visitor**: Separates an algorithm from the objects on which it operates.
---
### Diagram
![DesignPatterns drawio](https://github.com/user-attachments/assets/7cacb92d-969c-4972-9e51-6978850038a8)

## Contribution
Contributions are welcome! Please follow the steps below to contribute:
1. **Fork the repository**.
2. **Create a branch**: `git checkout -b feature/YourFeature`.
3. **Commit your changes**: `git commit -m 'Add a new pattern/example'`.
4. **Push to the branch**: `git push origin feature/YourFeature`.
5. **Create a pull request**.

## License
This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Author
[**Muhammad Murtaza**](https://github.com/murtaza12)
