# Adapter Design Pattern with Unit Testing

## Overview
The Adapter design pattern is a structural pattern that allows incompatible interfaces to work together. It acts as a bridge between two incompatible classes by converting the interface of one class into another that a client expects.

This example demonstrates the Adapter design pattern with the following features:
1. Integration of multiple payment gateways with different interfaces into a unified interface.
2. Real-world implementation with PayPal and Stripe payment systems.
3. Flexibility to add more payment gateways without modifying the existing client code.

---

## Types of Adapters
1. **Object Adapter**  
   The adapter uses composition to adapt the interface of an existing object to the target interface.

   **Pros:** Flexible, as it can work with multiple adaptees.  
   **Cons:** Requires a reference to the adaptee.

2. **Class Adapter**  
   The adapter uses inheritance to adapt the interface of a class to the target interface.

   **Pros:** Simple implementation.  
   **Cons:** Limited to single inheritance in languages like C#.

---

## Use Case of Adapter Design Pattern
1. **Payment Gateway Integration**  
   Unify the interface for processing payments with different gateways (e.g., PayPal and Stripe).

2. **Legacy Code Integration**  
   Allow new systems to work with old legacy systems without modifying them.

3. **Third-Party API Integration**  
   Adapt third-party libraries or APIs to fit the needs of your system.

---

## Design Pattern Benefits
- **Interface Compatibility:** Allows incompatible systems to work together seamlessly.  
- **Open/Closed Principle:** New adapters can be added without modifying existing code.  
- **Reusability:** Adaptees can be reused without altering their original implementation.  

---

## Unit Testing

### Purpose
Unit tests validate the behavior of the Adapter design pattern to ensure:
1. Proper adaptation of interfaces.
2. Correct functionality of adapted methods.

### Test Cases
#### Object Adapter Tests:
1. Verify that the `PayPalAdapter` processes payments correctly through `IPaymentProcessor`.
2. Verify that the `StripeAdapter` processes payments correctly through `IPaymentProcessor`.

#### Integration Tests:
1. Confirm that the client code interacts seamlessly with both adapters using the unified interface.

---

## Conclusion
The Adapter design pattern is a powerful structural pattern that simplifies integration between incompatible systems. By demonstrating a real-world example of payment gateway integration, this project shows how to use the pattern effectively to achieve interface compatibility and maintain flexibility in your code.
