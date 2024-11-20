# Singleton Design Pattern with Unit Testing

## Overview

The **Singleton** design pattern ensures that a class has only one instance while providing a global point of access to it. This pattern is widely used in scenarios where a single instance of a class is required to coordinate actions across the system.

This example demonstrates three types of Singleton implementations:
1. **Eager Singleton**
2. **Lazy Singleton**
3. **Thread-Safe Singleton**

Each implementation has its unique characteristics, suited for different use cases.

---

## Types of Singleton Implementations

### 1. **Eager Singleton**

In this implementation, the instance is created at the time of class loading.  
- **Pros**: Simple and thread-safe.
- **Cons**: Instance is created even if it is never used.

### 2. **Lazy Singleton**

This implementation delays the creation of the instance until it is needed.  
- **Pros**: Saves memory and resources if the instance is never used.
- **Cons**: Not thread-safe without additional mechanisms.

### 3. **Thread-Safe Singleton**

This implementation ensures the Singleton instance is created safely in multi-threaded environments.  
- **Pros**: Handles concurrent threads.
- **Cons**: Slightly more complex than other implementations.

---

## Use Case of Singleton Design Pattern

### 1. **Database Connections**
Ensure only one database connection instance exists across the application, preventing resource wastage.

### 2. **Configuration Management**
Centralize access to application configuration settings using a Singleton.

### 3. **Logging**
Provide a single instance for logging activities across the system to maintain consistency and avoid resource overhead.

---

## Benefits of Singleton Design Pattern

- **Controlled Access**: Restricts instantiation of a class to one object.
- **Global Access**: Provides a global point of access to the single instance.
- **Resource Management**: Saves memory by preventing multiple instantiations of the same object.

---

## Unit Testing

### Purpose
Unit tests validate the Singleton implementations to ensure:
- Only one instance is created for each type.
- The instance provides consistent and expected behavior.

### Test Cases

1. **Eager Singleton Tests**:
   - Validate that only one instance exists.
   - Check the functionality of the instance.

2. **Lazy Singleton Tests**:
   - Ensure the instance is created lazily.
   - Confirm that the instance behaves as expected.

3. **Thread-Safe Singleton Tests**:
   - Test the thread-safety of instance creation.
   - Verify consistent behavior in multi-threaded scenarios.

---

## Conclusion

The Singleton pattern is a simple yet powerful design pattern, ensuring a single instance of a class is created. This repository demonstrates three common implementations of the Singleton pattern, complete with unit tests to validate their behavior. Use this pattern wisely, as overuse can lead to tightly coupled code.
