# IA-Board-Game-Engine
A board game engine for IA players.

Instead of play a board game agains other human, your challange is to build a IA (or a series of Ifs) to play on your place agains other IAs.

But, first we must finish the engine that asks the movement for each IA, validate it, updates the board and evaluate a winner.


# How to Contribute

You can make suggestions opening a new issues and participate resolving a issue and opening a pull request.


# Solution General Structure:

### IABoardGameEngine.Core (Class Library Standard 2.1)
Contains all the logical classes and interfaces. It's the core of the project.
The main class and EntryPoint is BoardEngine class.

### IABoardGameEngine.Core.Tests (XUnit test project)
Contains unit tests for IABoardGameEngine.Core classes implementations.

### IABoardGameEngine.WebApp (ASP.NET Core 3.0)
A Web Application Layer to expose endpoints and features. It serves as a human interface to IABoardGameEngine.Core.
