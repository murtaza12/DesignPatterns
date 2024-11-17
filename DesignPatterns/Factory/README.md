# Factory Design Pattern with Unit Testing

## Overview

The **Factory** design pattern provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. This pattern is particularly useful when the exact type of object to be created is determined at runtime, allowing the system to remain flexible and maintainable.

This example demonstrates the Factory pattern in a scenario where different types of **Animals** (Dog and Cat) are created by an `AnimalFactory`. The factory encapsulates the object creation logic, making it easy to extend with new animal types in the future.

### Key Concepts:

- **Factory**: A static class that provides a method for creating instances of animals based on a given type.
- **Products**: Represents the actual types (Dog and Cat) created by the factory.
- **Unit Testing**: Verifies that the correct types of animals are being created based on the input type, ensuring the factory behaves as expected.

### Run Unit Tests

``` bash
dotnet test tests/CreationalDesignPatterns/Factory.Test/Factory.Test.csproj
```

## Design Pattern Benefits

- **Encapsulation of Object Creation**:  
  The Factory pattern centralizes the creation logic in one location, making it easy to manage and modify the creation of related objects.

- **Flexibility**:  
  New types of animals (e.g., Bird or Fish) can be added without changing the client code that uses the factory. This makes the system adaptable to new requirements.

- **Single Responsibility Principle**:  
  By separating the object creation logic, the Factory class follows the Single Responsibility Principle, making the code more organized and easier to maintain.

## Conclusion

The Factory pattern is a creational design pattern that allows for flexible and controlled object creation. By using this pattern, we created an example `AnimalFactory` that produces different types of animals (Dog and Cat) based on input. The accompanying unit tests validate that the correct animal types are created, ensuring the reliability and scalability of the factory design.
