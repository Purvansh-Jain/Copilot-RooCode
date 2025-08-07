
# GitHub Copilot & RooCode Training Plan

This document outlines a structured training plan for developers to effectively use **GitHub Copilot** and **RooCode** for AI-assisted coding. It contains detailed installation instructions, usage guidance, prompt engineering best practices, hands-on training exercises, and curated resources.

Offshore development teams can use this document to integrate Copilot or RooCode into their workflows and enhance productivity.

---

## 1. Introduction

AI tools like GitHub Copilot and RooCode are revolutionizing software development by assisting with code generation, refactoring, documentation, testing, and more. However, many developers are unfamiliar with how to use these tools efficiently. This training plan is designed to guide them through the setup, usage, and optimization of these tools in their daily work.

We focus on two primary tools:

* **GitHub Copilot**: An AI coding assistant by GitHub and OpenAI.
* **RooCode**: A privacy-preserving, offline-capable AI coding assistant that runs locally with support for custom models.

---

## 2. Installing and Enabling GitHub Copilot

GitHub Copilot provides autocomplete-style AI suggestions in VS Code based on natural language comments and code context. Here’s how to set it up and use it effectively:

### A. Prerequisites

* Ensure you have a GitHub account.
* Ensure your GitHub account is connected to the **Programmers.io organization** to enable enterprise license access.
* Install [Visual Studio Code](https://code.visualstudio.com/).

### B. Installation

1. **Open VS Code**
2. Press `Ctrl+Shift+X` to open the Extensions pane.
3. Search for "GitHub Copilot" and click **Install**.

### C. Authentication

* Sign into GitHub when prompted.
* Authorize the Copilot plugin to access your account.

### D. Enable Copilot

* Once installed, Copilot suggestions will appear as faded text while typing.
* Press `Tab` to accept a suggestion.
* You can disable or pause suggestions through the Copilot status bar icon.

### E. GitHub Copilot Chat (Optional)

1. Install **GitHub Copilot Chat** from the VS Code marketplace.
2. This extension enables a ChatGPT-like sidebar in VS Code.
3. Use it to ask questions, generate functions, refactor code, or understand code snippets.

### F. Using Copilot Effectively

* Use high-level natural language comments (e.g. `// Create a REST API in Express.js`) before writing code.
* Copilot works better with context: include type hints, docstrings, or partial function names.
* You can prompt it in comments, inline, or even use the chat window.

### G. Copilot Limitations

* It may not always generate optimal or secure code.
* Always review and test the output.

For further reading:

* [GitHub Copilot Official Docs](https://docs.github.com/en/copilot)
* [How to Write Better Prompts for GitHub Copilot](https://github.blog/2023-09-12-how-to-write-better-prompts-for-github-copilot/)

---

## 3. Using RooCode

RooCode is a local-first alternative to GitHub Copilot that supports self-hosted models and private environments. Here’s how to install and use it:

### A. Install RooCode Extension

1. Visit [RooCode GitHub](https://github.com/RooCodeInc/Roo-Code) and download the VS Code extension.
2. Install the extension manually or through the VS Code marketplace.

### B. Connect to an AI Provider

1. RooCode supports OpenAI, Azure OpenAI, or local models like Ollama.
2. Go to **Settings > RooCode > API Provider** and enter your API key.
3. For local models, configure your model and port (e.g., `http://localhost:11434/api`).

### C. Try Your First Prompt

* Press `Ctrl+Shift+P`, select **Roo Code: Run**.
* Ask questions like "Refactor this function to use async/await" or "Generate tests for this class".
* RooCode supports three modes:

  * **Code Mode**: Generates and edits code.
  * **Architect Mode**: High-level planning and scaffolding.
  * **Doc Mode**: Documentation, comments, PR summaries.

### D. Prompt Usage Across Files

* RooCode can read the open folder and files.
* It can edit files, navigate multiple tabs, and generate documentation.
* Use it to summarize large files or explain architecture.

### E. Privacy & Control

* RooCode does not send data to external servers unless using OpenAI.
* Local model support makes it ideal for sensitive projects.

Learn more:

* [RooCode Docs](https://docs.roocode.com)
* [RooCode GitHub](https://github.com/RooCodeInc/Roo-Code)

---

## 4. Prompt Engineering Best Practices

Effective prompt engineering is essential to leverage Copilot and RooCode. Follow these practices:

### A. Set a Clear Objective

* Always start with a clear, concise instruction.
* Example: `// Create a RESTful API for user registration using Express.js`

### B. Keep It Simple

* Break tasks into smaller, atomic prompts.
* Avoid combining multiple asks in one line.

### C. Be Specific with Examples

* Show examples in comments or as context.
* Copilot learns better when you show structure.

### D. Iterate and Refine

* If the output is unsatisfactory, modify your prompt or add more detail.

### E. Use Chat Interfaces for Exploration

* Tools like Copilot Chat and ChatGPT help you debug, paraphrase, or polish prompts.

Example Prompt Improvements:

* ❌ *"Make this code better"* → ✅ *"Optimize this loop using list comprehension in Python"*
* ❌ *"Fix bug"* → ✅ *"Fix index out of range error in line 12 by checking array length"*

More resources:

* [GitHub Prompt Guide](https://github.blog/2023-09-12-how-to-write-better-prompts-for-github-copilot/)
* [OpenAI Prompt Engineering Guide](https://platform.openai.com/docs/guides/prompt-engineering)

---

## 5. Training Exercises

Work through these exercises in the included `training_repo`:

1. **Code Migration**

   * Refactor `legacy_code/Calculator.cs` to use modern C# syntax.
   * Compare with `modern_code/Calculator.cs`.

2. **Module Scaffolding**

   * Use the BRD in `requirements/BRD.md`.
   * Ask RooCode or Copilot to scaffold a service module.

3. **Unit Test Generation**

   * Use the `Calculator.cs` file.
   * Ask AI to generate NUnit/xUnit tests. Run and verify coverage.

4. **Documentation & Diagrams**

   * Ask RooCode to create markdown and mermaid diagrams.
   * Review structure and clarity.

---

## 6. Additional Resources

### Articles

* [GitHub Blog – Better Prompts for Copilot](https://github.blog/2023-09-12-how-to-write-better-prompts-for-github-copilot/)
* [RooCode Official Documentation](https://docs.roocode.com)
* [We Are Founders – Roo Code Overview](https://wearefounders.substack.com/p/roocode)

### Videos (YouTube)

| Topic            | Video Title                                         | Link                                                 | Description                               |
| ---------------- | --------------------------------------------------- | ---------------------------------------------------- | ----------------------------------------- |
| Copilot Beginner | *How to Use GitHub Copilot (Beginner's Guide)*      | [Watch](https://www.youtube.com/watch?v=n0NlxUyA7FI) | Basic install and use                     |
| Copilot Tips     | *Get the Most Out of GitHub Copilot – ng-conf 2024* | [Watch](https://www.youtube.com/watch?v=rzT5Jmj6tUw) | Tips on refactoring, reviewing, prompting |
| RooCode Setup    | *RooCode v3.3 UPDATE: Free Autonomous Coding Agent* | [Watch](https://www.youtube.com/watch?v=PE-0P6SAZYc) | Install + config guide                    |
| RooCode Features | *Roo Code is AMAZING – AI VSCode Extension*         | [Watch](https://www.youtube.com/watch?v=r5T3h0BOiWw) | Showcases Architect and Doc mode          |

---

## 7. Next Steps

1. Complete all training exercises.
2. Share feedback and pain points.
3. Explore advanced topics such as:

   * Connecting RooCode to local LLMs
   * Using vector databases (e.g., FAISS) with code search
   * Prompt chaining with tools like LangChain

With continued use and refinement, Copilot and RooCode can help teams code faster, document better, and onboard new members more efficiently.
