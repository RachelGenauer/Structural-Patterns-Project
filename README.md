# 🧩 Structural Patterns Project

A clean and practical implementation of the seven classic **Structural Design Patterns** (Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy) in C#.  
Built to demonstrate how to assemble objects and classes into flexible, maintainable structures.  

> This project reflects my ability to apply software-design best practices to real-world code, writing modular, reusable, and scalable solutions.

---

## 🧠 Why Structural Patterns?

Structural patterns help organize relationships between objects, allowing developers to:

- Simplify complex class architectures  
- Reuse code more effectively  
- Adapt interfaces or hide system complexity :contentReference[oaicite:1]{index=1}  
- Improve performance (e.g., memory sharing in Flyweight) :contentReference[oaicite:2]{index=2}  

---

## 🧱 Implemented Patterns

Each pattern is implemented with a small demo illustrating:

1. **Adapter** – Wrapping incompatible interfaces  
2. **Bridge** – Decoupling abstraction and implementation  
3. **Composite** – Managing object trees uniformly  
4. **Decorator** – Dynamically extending behavior  
5. **Facade** – Simplifying a subsystem's interface  
6. **Flyweight** – Sharing common state for performance  
7. **Proxy** – Controlling access to an object  

---

## 🛠 Tech Stack

- **Language:** C# (.NET Core)  
- **Structure:**  
  - Individual folders for each pattern  
  - Interface + implementation + demo for each  
- **Approach:** Clear naming, SOLID principles, minimal dependencies  
- **Testing & Demos:** Console-based examples showcase usage  

---

## 🎯 How to Use

```bash
git clone https://github.com/RachelGenauer/Structural-Patterns-Project.git
cd Structural-Patterns-Project
dotnet run --project AdapterDemo
