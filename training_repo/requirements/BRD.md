# Business Requirement Document (BRD)

## Title: Simple Calculator Service

### Goal

Develop a simple calculator service that can perform basic arithmetic operations — addition, subtraction, multiplication and division — for two numeric operands. The service should expose a public API that accepts two numbers and an operation name and returns the result. 

### Functional Requirements

1. **Addition** – Given two numbers, return their sum.
2. **Subtraction** – Given two numbers, return the result of subtracting the second number from the first.
3. **Multiplication** – Given two numbers, return their product.
4. **Division** – Given two numbers, divide the first by the second and return the quotient. If the second number is zero, return an error message such as `"Divide by zero not allowed"`.
5. **API** – Expose the above operations through a method or endpoint that accepts two numeric inputs and a string specifying the operation (`add`, `subtract`, `multiply`, `divide`).
6. **Input Validation** – Validate that input values are numeric. If they are not numeric or missing, return a user‑friendly error.
7. **Logging** – Log each request and result for auditing purposes.

### Non‑Functional Requirements

1. **Performance** – Operations should return results within milliseconds.
2. **Scalability** – The service should be able to handle multiple concurrent requests.
3. **Usability** – The API should be intuitive with clear error messages.
4. **Maintainability** – Code should be clean, well‑documented and adhere to modern C# coding standards.

### Sample Request

```
POST /calculator
{
  "a": 10,
  "b": 5,
  "operation": "divide"
}
```

### Sample Response

```
{
  "result": 2
}
```

### Notes

This is a small example designed for training. The patterns and principles used here can be applied to larger and more complex systems. When working with AI tools, you can feed this document as context to generate scaffolding, controller classes, unit tests and documentation.