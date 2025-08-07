# Sample AI-assisted Development Repository

This repository is designed to demonstrate how AI tools such as **GitHub Copilot** and **RooCode** can assist developers during common tasks like code migration, scaffolding new modules from business requirements and generating test cases.

## Structure

```
training_repo/
  README.md           – this file
  requirements/
    BRD.md            – example business requirements document
  legacy_code/
    Calculator.cs      – sample legacy C# class using an older coding style
  modern_code/
    Calculator.cs      – modernised version of the legacy class (C# 10 / .NET 8)
```

The contents of this repository are intentionally simple so they can be used as a learning exercise.

## How to use this repository with AI tools

1. **Explore the legacy code** (`legacy_code/Calculator.cs`) and read the business requirements in `requirements/BRD.md`.
2. Using **GitHub Copilot** or **RooCode**, prompt the tool to translate the legacy code into modern C# (for example targeting .NET 8) or scaffold a new service based on the requirements.
3. Ask the AI to generate unit tests or documentation for the resulting code.
4. Compare the AI‑generated output with the sample `modern_code/Calculator.cs` and refine your prompts accordingly.

By practising on this repository, developers can learn how to structure prompts, iterate with AI suggestions and validate the results.