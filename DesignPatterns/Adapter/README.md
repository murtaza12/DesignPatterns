# Adapter Design Pattern with Unit Testing

## Overview
The Adapter design pattern is a structural pattern that allows incompatible interfaces to work together. It acts as a bridge between two incompatible classes by converting the interface of one class into another that a client expects.

This project demonstrates the Adapter design pattern with two real-world examples:
1. Payment Gateway Integration (Object Adapter).
2. Media Player Integration (Class Adapter).

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

### Object Adapter Use Case
1. **Payment Gateway Integration:**  
   Unify the interface for processing payments with different gateways (e.g., PayPal and Stripe).

2. **Legacy Code Integration:**  
   Allow new systems to work with old legacy systems without modifying them.

### Class Adapter Use Case
1. **Media Player Integration:**  
   Adapt a legacy media player (`AdvancedMediaPlayer`) to work with a modern `MediaPlayer` interface. 

2. **Third-Party Library Integration:**  
   Adapt third-party libraries or APIs using class inheritance.

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

#### Object Adapter Tests
1. Verify that the `PayPalAdapter` processes payments correctly through `IPaymentProcessor`.
2. Verify that the `StripeAdapter` processes payments correctly through `IPaymentProcessor`.

#### Class Adapter Tests
1. Validate that the `MediaAdapter` correctly plays VLC and MP4 files.
2. Ensure that the client (`AudioPlayer`) seamlessly interacts with the adapter (`MediaAdapter`).
3. Confirm proper error handling for unsupported file formats.

---

## Conclusion
The Adapter design pattern is a powerful structural pattern that simplifies integration between incompatible systems. By demonstrating both **Object Adapter** (Payment Gateway Integration) and **Class Adapter** (Media Player Integration) examples, this project showcases how the Adapter pattern can be leveraged effectively to achieve interface compatibility and maintain flexibility in your code.
