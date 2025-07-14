# 🚚 Logistics Delivery System – Simple Factory Demo

A **console application** that demonstrates the *Simple Factory* design pattern by creating different `ITransport` objects (`Truck`, `Ship`, `AirPlane`) based on user input.

---

## 📁 Table of Contents

1. [Motivation](#motivation)
2. [How It Works](#how-it-works)
3. [Prerequisites](#prerequisites)
4. [Running the Demo](#running-the-demo)
5. [Sample Session](#sample-session)
6. [Extending the Factory](#extending-the-factory)
7. [Focus of This Demo](#focus-of-this-demo)

---

## Motivation

When teaching design patterns, it helps to start small. The **Simple Factory** is not a formal GoF pattern, but it sets the stage for *Factory Method* & *Abstract Factory*. This project shows how you can:

* Decouple *object creation* from *client code*.
* Swap transport types without touching the delivery workflow.
* Keep the main loop readable and focused on user interaction.

---

## How It Works

1. **User Input**   → Console asks for a transport type.
2. **Factory Decision**   → `SimpleTransportFactory.Create(type)` (inlined for brevity) decides which concrete transport to instantiate.
3. **Polymorphic Use**   → The returned `ITransport` object could later expose methods like `Deliver()` or `GetETA()`, all called through the interface, not the concrete class.

> **Note:** In this minimal demo, we only announce the created transport. Add behavior as an exercise (see [Extending the Factory](#extending-the-factory)).

---

## Prerequisites

* .NET SDK **8.0** or later
* Any OS that supports .NET (Windows / macOS / Linux)

```bash
# verify SDK
 dotnet --version
```

---

## Running the Demo

```bash
# 1. clone or download
 git clone https://github.com/your-repo/SimpleFactoryLogistics.git
 cd SimpleFactoryLogistics

# 2. build & run
 dotnet run
```

Then follow the on-screen prompts:

```text
=== Logistics Delivery System ===
Enter transport type (Truck / Ship / Airplane) or 'exit' to quit: Truck
[✔] Transport Created: Truck
```

---

## Sample Session

```text
=== Logistics Delivery System ===
Enter transport type (Truck / Ship / Airplane) or 'exit' to quit: Ship
[✔] Transport Created: Ship
----------------------------------------
Enter transport type (Truck / Ship / Airplane) or 'exit' to quit: Plane
[❌] Unknown transport type. Please try again.
----------------------------------------
Enter transport type (Truck / Ship / Airplane) or 'exit' to quit: exit

Exiting system... Goodbye!
```

---

## Extending the Factory

| New Feature            | Where to Add                                                                            | Hint                                    |
| ---------------------- | --------------------------------------------------------------------------------------- | --------------------------------------- |
| **Deliver** method     | Implement `void Deliver(string origin, string destination)` in each concrete transport. | Show different speeds/ETAs.             |
| **Cost Estimation**    | Add a `double CalculateCost(double distanceKm)` method to `ITransport`.                 | Make air more expensive than sea/truck. |
| **Real Factory Class** | Extract the `if/else` block into `SimpleTransportFactory`.                              | Returns `ITransport`.                   |
| **Enum Input**         | Replace string parsing with an enum + `Enum.TryParse`.                                  | Less error-prone.                       |

---

## 🧠 Focus of This Demo

This project focuses **only** on the **Simple Factory** pattern — a stepping stone toward understanding more advanced creation patterns.

It’s meant to teach:

* ✅ How to centralize object creation
* ✅ How to return `ITransport` without exposing concrete classes
* ✅ How to decouple creation logic from business flow

Other factory patterns like **Factory Method** and **Abstract Factory** will be introduced in separate examples.

> This keeps the learning curve gradual and avoids mixing concepts too early.

---

Happy coding! ✨
