# Abstract Factory Design Pattern with Unit Testing

## Overview

The **Abstract Factory** design pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. The goal of this pattern is to allow a system to be independent of how its objects are created, composed, and represented. The Abstract Factory pattern is particularly useful when the system needs to work with multiple families of products, and the client needs to create objects from one family.

This example demonstrates the Abstract Factory pattern in a real-world scenario where different types of **Car Components** (Engines and Tires) are produced by two different car factories: **ElectricCarFactory** and **GasolineCarFactory**.

### Key Concepts:
- **Abstract Factory**: Defines the interface for creating a set of related products (Engines and Tires).
- **Concrete Factories**: Implements the creation of the concrete products (ElectricCarFactory and GasolineCarFactory).
- **Products**: Represents the actual components (Engine and Tire) produced by the factories.
- **Unit Testing**: Verifies that the correct products are being created by each factory.

### Run Unit Tests

```bash
dotnet test AbstractFactory.Test/AbstractFactory.Test.csproj
```

## Design Pattern Benefits

**1. Flexibility:**
    Abstract Factory allows the system to work with different families of related products, and you can easily introduce new families without altering existing code.

**2. Consistency**:
    Ensures that the objects created are compatible with each other. In this case, Electric Car components are only created by the ElectricCarFactory, and Gasoline Car components are only created by the GasolineCarFactory.

**3. Scalability:**
    You can add new car factories (e.g., HybridCarFactory) or components (e.g., HybridTire) without changing the existing code. This keeps the system extensible.

## Conclusion

The Abstract Factory pattern is a creational design pattern that helps in creating families of related objects without specifying their concrete classes. By using this pattern, we have created an example of two types of car factories (Electric and Gasoline), each responsible for producing related products (Engines and Tires). The provided unit tests ensure that the correct components are created by each factory.