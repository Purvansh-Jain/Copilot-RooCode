# GitHub Copilot & RooCode Training Plan

This document outlines a step‑by‑step training plan to enable offshore developers to use **GitHub Copilot** and **RooCode** effectively. It provides installation instructions, usage tips, links to videos and articles, and exercises to build confidence.

## 1. Introduction

Developers across the globe are expected to use AI assistance to increase productivity. Many of our offshore developers have not yet integrated **Copilot** or **RooCode** into their daily workflows. The goal of this training is to bridge that gap.

## 2. Installing and Enabling GitHub Copilot

1. **Get Access** – Ensure your GitHub account has a Copilot subscription or is part of our enterprise licence.
2. **Install the Extension** – In **Visual Studio Code**, open the Extensions view (`Ctrl+Shift+X`), search for **GitHub Copilot** and click **Install**.
3. **Authenticate** – Sign into GitHub when prompted and enable Copilot for your account.
4. **Enable in Your IDE** – After installation, you will see Copilot suggestions appear as ghost text. Accept a suggestion with `Tab`.
5. **Copilot Chat (Optional)** – Copilot Chat allows conversational queries within VS Code. Install **GitHub Copilot Chat** extension from the marketplace and sign in.

More details can be found in GitHub’s official documentation and blog posts. For example, GitHub recommends that you set a high‑level goal in your prompt and break your ask into discrete steps for better results【364202183360539†L586-L616】. Keeping prompts simple and specific also improves Copilot’s response quality【364202183360539†L632-L656】.

## 3. Using RooCode

1. **Install RooCode** – Download and install the **RooCode** extension from [roocode.com](https://roocode.com). Note that RooCode is open source and runs locally【443559697559150†L27-L52】.
2. **Connect an AI Provider** – RooCode can connect to OpenAI, Azure OpenAI or your own local model. Configure your API key in RooCode’s settings.
3. **Try Your First Task** – Use the command palette (Ctrl+Shift+P) and select **Roo Code: Run** to generate code, refactor or answer questions. RooCode supports multiple modes such as *Code*, *Architect* and *Doc* mode【780901266607041†L87-L123】.
4. **Explore Prompts Across Files** – RooCode can read and write files, execute commands and provide PR summaries【443559697559150†L50-L62】.
5. **Privacy & Control** – RooCode is transparent and local; none of your code is sent to a hosted service【443559697559150†L64-L70】.

## 4. Prompt Engineering Best Practices

Successful AI assistance begins with clear prompts. GitHub recommends:

- **Set the stage with a high‑level goal** – Provide an overview of what you want to accomplish【364202183360539†L586-L616】.
- **Keep it simple and specific** – Ask for one thing at a time; avoid ambiguous language【364202183360539†L632-L656】.
- **Give examples** – Show one or two inputs and outputs so the AI understands your expectations【364202183360539†L658-L723】.

When you struggle to articulate your prompt in English, use ChatGPT or another language model to refine your prompt. For example: *“Rephrase my prompt in clear, concise English and suggest missing details.”* This will help the AI generate better results.

## 5. Training Exercises

Work through the following exercises using the **`training_repo`** provided in this package:

1. **Code Migration** – Open `legacy_code/Calculator.cs` and ask Copilot to refactor it to a modern C# pattern. Compare your results with `modern_code/Calculator.cs`.
2. **Module Scaffolding** – Use the BRD in `requirements/BRD.md` to ask RooCode (or Copilot Chat) to scaffold a new calculator service. Evaluate the output and iterate on your prompt.
3. **Unit Test Generation** – Provide the code of a class (e.g. `Calculator.cs`) and ask the AI to generate unit tests using xUnit or NUnit. Run the tests and review coverage.
4. **Documentation and Diagrams** – Ask RooCode to generate Markdown documentation and a Mermaid diagram of the `Calculator` class. Discuss whether the output is accurate and where it can be improved.

## 6. Additional Resources

### Articles
- **GitHub Blog – How to Write Better Prompts for GitHub Copilot** – covers best practices for crafting prompts【364202183360539†L586-L616】【364202183360539†L632-L656】【364202183360539†L658-L723】.
- **Roo Code Documentation** – explains installation, modes and capabilities【780901266607041†L61-L75】【780901266607041†L87-L123】.
- **We Are Founders – Roo Code Overview** – describes RooCode’s local/offline nature and privacy benefits【443559697559150†L27-L52】【443559697559150†L64-L70】.

### Videos (YouTube)

The following videos provide visual walkthroughs of AI coding tools. Always verify dates and quality. Here are some recommended titles to search for:

| Topic | Video Title (YouTube) | Description |
|------|----------------------|-------------|
| **Copilot Beginner Guide** | *How to Use GitHub Copilot (Beginner's Guide)* | Demonstrates installation and basic usage of Copilot in VS Code. |
| **Copilot Tips & Tricks** | *Get the Most Out of GitHub Copilot* (ng‑conf 2024 talk) | Offers practical tips on prompting, refactoring and code review. |
| **RooCode Setup** | *Installing Roo Code in VS Code – Quick Setup Tutorial* | Shows how to install and configure RooCode with your own model. |
| **RooCode Features** | *Roo Code is AMAZING – AI VSCode Extension* | Highlights different modes and how to automate tasks. |

## 7. Next Steps

1. **Complete the exercises** and record any questions or issues you encounter.
2. **Share feedback** with the training coordinators so the materials can be improved.
3. **Continue exploring** – Beyond Copilot and RooCode, investigate other AI tools and experiment with different prompt strategies.

By following this plan, our offshore teams will develop confidence in using AI to accelerate their workflow. Over time, these tools will become part of their daily development process.