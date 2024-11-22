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

# Comparison of Object Adapter and Class Adapter

| Feature                        | **Object Adapter**                                                   | **Class Adapter**                                                    |
|---------------------------------|----------------------------------------------------------------------|----------------------------------------------------------------------|
| **Adapter Type**                | Uses composition (delegation) to adapt the interface of an object.    | Uses inheritance (extends) to adapt the interface of a class.        |
| **Flexibility**                 | More flexible; can work with multiple classes and adaptees.          | Less flexible; limited to single inheritance in languages like C#.   |
| **Reuse of Adaptee**            | Adaptee objects are passed into the adapter, and their behavior is reused. | Adaptee behavior is inherited by the adapter.                        |
| **Extensibility**               | Easier to extend; new adapters can be created without modifying the existing ones. | Harder to extend due to inheritance limitations.                     |
| **Use Case**                    | Best suited for scenarios where you need to adapt many different objects (e.g., payment gateways). | Best suited when you have a single class to adapt (e.g., a specific media player). |
| **Example**                     | Integrating multiple payment gateways (e.g., PayPal, Stripe) into a single unified interface. | Adapting a media player that can play different file formats (e.g., VLC and MP4). |
| **Code Complexity**             | More complex due to composition and delegation.                      | Simpler as it uses inheritance.                                      |
| **Implementation**              | Adapts objects using interfaces and composition (i.e., wraps the adaptee object). | Adapts classes by inheriting the functionality of a specific class.   |
| **Performance**                 | May incur a slight performance overhead due to composition.          | Typically more efficient due to direct inheritance.                  |
| **Example Code Structure**      | Requires an interface and an adaptee class that is passed into the adapter. | Adapter class directly extends an adaptee class and overrides methods. |
| **Error Handling**              | Easy to handle unsupported formats or actions.                      | Error handling is limited by the constraints of inheritance.         |
| **Adapter**                     | A separate adapter class that implements the target interface and delegates calls to the adaptee. | A single adapter class that inherits from the adaptee and implements the target interface. |
| **Adaptee**                     | The existing class whose interface is being adapted.                | The existing class whose functionality is being inherited by the adapter. |
| **Target**                      | The interface that the client expects, which is provided by the adapter. | The interface that the client expects, which is provided by the adapter. |
| **Client**                      | The class that interacts with the adapter to access the adapted functionality. | The class that interacts with the adapter to access the adapted functionality. |

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
