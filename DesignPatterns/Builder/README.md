# Builder Design Pattern with Unit Testing

## Overview

The **Builder** design pattern is a creational design pattern that allows for the step-by-step construction of complex objects. This pattern provides a clear separation between the representation of an object and its construction process. It is particularly useful when creating objects with multiple configurations or composed of several parts.

This example demonstrates the Builder pattern in a restaurant scenario, where different types of **Meals** are created using a `MealBuilder`. The `MealBuilder` encapsulates the logic for assembling a meal consisting of a main course, a side dish, and a drink.

### Key Concepts:

- **Builder**: Defines an interface for constructing various parts of a product (in this case, meals).
- **ConcreteBuilder**: Implements the steps defined in the builder interface to create specific meal types.
- **Product**: Represents the final object being built (e.g., `Meal`).
- **Director**: Oversees the construction process, ensuring the correct sequence of building steps.

---

## Use Case of Builder Design Pattern

### Restaurant Meal Assembly

In a restaurant, customers can order meals consisting of various combinations of a main course, side dish, and drink. The Builder pattern helps simplify the creation of these meals by providing a clear and consistent way to assemble them, while allowing flexibility to add or modify components as needed.

For example:
1. A **Vegetarian Meal** might include a vegetable curry (main course), salad (side dish), and orange juice (drink).
2. A **Standard Meal** might include a steak (main course), fries (side dish), and cola (drink).

The Builder pattern ensures that the meal assembly process is reusable and easy to extend for new meal types.

---

## Design Pattern Benefits

- **Step-by-Step Construction**:  
  Allows for the stepwise creation of complex objects, making the process clear and manageable.

- **Flexibility**:  
  Builders can create different representations of the same object, making it easy to produce variations.

- **Encapsulation**:  
  The Builder encapsulates the construction logic, hiding the details of object creation from the client.

- **Separation of Concerns**:  
  By decoupling the construction process from the product’s representation, the Builder pattern adheres to the Single Responsibility Principle.

---

## Code Overview

### Key Components

1. **Builder Interface**:
   Defines methods for building the components of a meal (e.g., main course, side dish, drink).

2. **Concrete Builder**:
   Implements the builder interface to create specific meal types like `VegetarianMealBuilder` and `StandardMealBuilder`.

3. **Product**:
   Represents the final object (`Meal`) that includes a main course, side dish, and drink.

4. **Director**:
   Orchestrates the building process by controlling the sequence of building steps.

---

## Unit Testing

Unit tests are provided to validate the functionality of the Builder pattern implementation. The tests ensure:
- Each meal is constructed correctly with its respective components.
- The `Director` correctly sequences the building steps to create the expected meal.

---

### Run Unit Tests

``` bash
dotnet test tests/Creational/Builder.Test/Builder.Test.csproj
```
---

### Test Cases:

1. **Vegetarian Meal Test**:  
   Ensures that the `VegetarianMealBuilder` creates a meal with the expected vegetarian components.

2. **Standard Meal Test**:  
   Verifies that the `StandardMealBuilder` constructs a meal with the specified components.

3. **Director Test**:  
   Tests that the `Director` orchestrates the building process correctly and produces the desired meals.

---

## Conclusion

The Builder pattern is a powerful creational design pattern that simplifies the construction of complex objects while maintaining flexibility and scalability. By using this pattern, we demonstrated how to assemble different types of meals in a restaurant scenario, ensuring the construction process is reusable and easy to modify. The provided unit tests validate the implementation, ensuring its reliability and correctness.
