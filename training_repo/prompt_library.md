# Prompt Library for AI‑assisted Development

This document contains example prompts that developers can use with **GitHub Copilot**, **RooCode** or other large language models. Each prompt is designed to guide the AI toward producing useful output. You can adapt them to suit your codebase and language.

---

## 1. Code Scaffolding / New Module

**Prompt:**

> **Goal:** Create a new C# service called `InvoiceService` that satisfies the following requirements:
> – Supports `CreateInvoice`, `GetInvoiceById` and `ListInvoices` operations.
> – Uses an in‑memory data store.
> – Follows the repository pattern and dependency injection best practices.
>
> Generate the service class, a repository interface with a simple implementation, and a controller class exposing these endpoints. Include XML documentation comments.

**Explanation:** This prompt sets the high‑level goal and lists the discrete requirements. You can adjust the language, framework (e.g. ASP.NET Core, Python Flask) or details as needed. Ask follow‑up questions if the output needs refinement.

---

## 2. Unit Test Generation

**Prompt:**

> Here is a C# class that implements a calculator:
>
> ```csharp
> public class Calculator
> {
>     public double Add(double a, double b) => a + b;
>     public double Subtract(double a, double b) => a - b;
>     public double Multiply(double a, double b) => a * b;
>     public double Divide(double a, double b)
>     {
>         if (b == 0) throw new DivideByZeroException();
>         return a / b;
>     }
> }
> ```
>
> Write a suite of unit tests using **xUnit** to verify each method, including a test that asserts a `DivideByZeroException` is thrown when dividing by zero.

**Explanation:** Provide the source code and specify the testing framework. You can replace xUnit with NUnit, Jest, pytest, etc., depending on the language.

---

## 3. Documentation Generation

**Prompt:**

> Generate Markdown documentation for the following C# class. Include a summary of the class, descriptions of each method and their parameters, and examples of how to use the class:
>
> ```csharp
> public class TemperatureConverter
> {
>     public double CelsiusToFahrenheit(double c) => c * 9 / 5 + 32;
>     public double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
> }
> ```

**Explanation:** The prompt asks for a specific output format (Markdown) and calls out the sections you need (summary, parameters, examples). You can similarly request Mermaid diagrams for flowcharts.

---

## 4. Code Migration (Framework/Language Upgrade)

**Prompt:**

> We have an ASP.NET MVC 5 controller written below. Rewrite it using ASP.NET Core 8 minimal APIs with dependency injection and strongly typed response models.
>
> Provide the equivalent code in `Program.cs` and any necessary classes.

**Explanation:** Highlight the source technology and the desired target technology. Provide the code snippet you want to migrate. You can ask the AI to refactor AngularJS to React, Python 2 to Python 3, etc.

---

## 5. Prompt Refinement (Using ChatGPT to Improve Prompts)

If your prompt feels unclear or yields poor results, ask ChatGPT or a similar model:

> *Original prompt:* "write micro service to handle invoice"
>
> *Refinement request:* "Rephrase the above prompt in clear, concise English and add any missing details that would help an AI model generate a robust solution."

The model will return an improved prompt, which you can then feed into Copilot or RooCode.

---

## 6. Questions About a Codebase

**Prompt:**

> In the repository I'm working on, find the class or module responsible for authentication. Explain its main functions and outline any known risks or security considerations.

**Explanation:** When asking AI to search a large codebase (supported in tools like RooCode), provide a clear objective and the type of information you seek. This helps the model navigate the repository effectively.

---

## 7. Error Explanation and Fix Suggestions

**Prompt:**

> I encountered the following error when running my .NET application:
>
> ```
> System.NullReferenceException: Object reference not set to an instance of an object.
> at MyApp.Services.OrderService.CreateOrder(Order order)
> ```
>
> Explain what this error means and suggest how to fix it in the given context. Include code examples if necessary.

**Explanation:** Provide the full error message and context so the AI can reason about potential causes. Request suggestions along with explanations.

---

Feel free to extend this library with your own prompts tailored to your stack and workflows.