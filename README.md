# OOP-Principles-CSharp
A C# console application demonstrating the four main Object-Oriented Programming (OOP) principles: Encapsulation, Inheritance, Abstraction, and Polymorphism.

## Features
- Encapsulation – Protects internal class data using private fields and public properties.
- Inheritance – Enables a class to reuse properties and methods from a parent class.
- Abstraction – Uses abstract classes to hide implementation details.
- Polymorphism – Allows method overriding for flexible and dynamic behavior.

📂 Project Structure
OOPPrinciple/
├── OOPPrinciple/
│   ├── Models/
│   │   ├── AbstractionDemo.cs
│   │   ├── EncapsulationDemo.cs
│   │   ├── InheritanceDemo.cs
│   │   └── PolymorphismDemo.cs
│   ├── bin/Debug/net8.0/
│   ├── obj/
│   ├── OOPPrinciple.csproj
│   └── Program.cs
├── OOPPrinciple.sln
└── README.md

🧠 OOP Principles Explained
PrincipleImplementation in CodeEncapsulationBankAccount class uses a private field _balance with public getter/setterInheritanceInterestAccount inherits from BankAccountAbstractionShape is an abstract class with CalculateArea() implemented by CirclePolymorphismDog overrides MakeSound() from Animal

▶️ How to Run
1. Clone the repository
bashgit clone https://github.com/your-username/OOPPrinciple.git
cd OOPPrinciple
2. Open in Visual Studio

File → Open → Project/Solution → Select OOPPrinciple.sln

3. Build and Run

Press Ctrl + F5 to run without debugging
Or use dotnet run in the terminal


🖥 Example Output
----Encapsulation----
Deposit: 1000 , New Balance: 1200
Withdraw: 600 , New Balance: 600

----Inheritance----
Deposit: 1000 , New Balance: 1000
Interest Added: 50
Withdraw Amount: 500

----Abstraction----
Area of Circle: 78.5

----Polymorphism----
Animal makes sound
Dog Sound: Woof Woof

📋 Requirements

.NET 8.0 or later
Visual Studio 2022 or Visual Studio Code
C# 12.0


🚀 Getting Started
If you're new to OOP concepts, this project demonstrates:

Encapsulation: Data hiding and controlled access
Inheritance: Code reusability through parent-child relationships
Abstraction: Hiding complex implementation details
Polymorphism: Same interface, different behaviors

Each principle is implemented in its own demo class for clarity and easy understanding.

📝 License
This project is licensed under the MIT License - see the LICENSE file for details.

👨‍💻 Author
Sushant Bidari
📍 Hetauda, Nepal
📧 sushantbidari7@gmail.com


🤝 Contributing
Contributions, issues, and feature requests are welcome! Feel free to check the issues page.
⭐ Show your support
Give a ⭐️ if this project helped you learn OOP concepts!
