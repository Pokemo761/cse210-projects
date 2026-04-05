# C# Final Project
**Author:** Marcos Perez 
**Course:** CSE 121C - Programming with Classes  
**Semester:** Winter 2026  
**Institution:** BYU-Idaho


The VS Code extension for dotnet didn't run the projects correctly unless you open them in individual windows in VS Code.

1. Youtube Videos Abstraction: Hides complecity (how comments are stored)

2. Online Ordering Encapsulation:  Everything is private, accessed through methods 
3. Event Planning Inheritance: Base class shares codees with derived classes.
4. Exercise Tracing Polymorphism: Same method, different behaviors

## Project Overview

This repository contains my final project for CSE 121C, demonstrating the four core principles of Object-Oriented Programming through the Foundation 4 project option.

## Project Structure

This project consists of four separate programs, each demonstrating a key OOP principle:

### Program 1: Abstraction with YouTube Videos
**Principle Demonstrated:** Abstraction

**Description:**  
A video tracking system for a product awareness monitoring company. The program manages YouTube videos and their comments, demonstrating abstraction by hiding the internal implementation of how comments are stored behind simple public methods.

**Classes:**
- `Video` - Stores video information and manages a list of comments
- `Comment` - Represents individual comments with commenter name and text

**Key Features:**
- Creates 4 videos with multiple comments each
- Displays video information including title, author, length, and comment count
- Lists all comments for each video
- Demonstrates abstraction through encapsulated comment management

---

### Program 2: Encapsulation with Online Ordering
**Principle Demonstrated:** Encapsulation

**Description:**  
An order management system for an online company that sells products worldwide. The program calculates shipping costs based on location and generates packing and shipping labels.

**Classes:**
- `Address` - Stores physical address information
- `Customer` - Represents a customer with name and address
- `Product` - Stores product details and calculates total cost
- `Order` - Manages products and calculates order totals with shipping

**Key Features:**
- Calculates USA ($5) vs International ($35) shipping
- Generates packing labels listing all products
- Creates shipping labels with customer information
- All member variables are private with public methods for access

---

### Program 3: Inheritance with Event Planning
**Principle Demonstrated:** Inheritance

**Description:**  
An event tracking system for an event planning company that handles lectures, receptions, and outdoor gatherings. Uses inheritance to avoid code duplication.

**Classes:**
- `Event` (Base Class) - Contains common event attributes (title, description, date, time, address)
- `Lecture` (Derived) - Adds speaker name and capacity
- `Reception` (Derived) - Adds RSVP email
- `OutdoorGathering` (Derived) - Adds weather forecast
- `Address` - Stores event location

**Key Features:**
- Generates three types of marketing messages:
  - Standard details (all events)
  - Full details (includes type-specific information)
  - Short description (for social media)
- Demonstrates inheritance by placing common code in base class
- Each event type adds its own unique attributes

---

### Program 4: Polymorphism with Exercise Tracking
**Principle Demonstrated:** Polymorphism

**Description:**  
A fitness tracking application for a local fitness center that tracks running, cycling, and swimming activities. Uses polymorphism to calculate distance, speed, and pace differently for each activity type.

**Classes:**
- `Activity` (Base Class) - Contains common attributes and virtual methods
- `Running` (Derived) - Stores distance, calculates speed and pace
- `Cycling` (Derived) - Stores speed, calculates distance and pace
- `Swimming` (Derived) - Stores laps, converts to distance, calculates metrics

**Key Features:**
- Each activity calculates metrics differently:
  - Running: Given distance → calculates speed/pace
  - Cycling: Given speed → calculates distance/pace
  - Swimming: Given laps → calculates distance/speed/pace
- Polymorphism allows same method calls for different behaviors
- Displays formatted summaries for all activities

---

## Technologies Used

- **Language:** C#
- **Framework:** .NET
- **IDE:** Visual Studio Code

## OOP Principles Demonstrated

**Abstraction** - Hiding implementation details behind simple interfaces  
**Encapsulation** - Private member variables with public methods  
**Inheritance** - Base classes sharing code with derived classes  
**Polymorphism** - Method overriding for different behaviors

## How to Run

Each program is independent and can be run separately:
```bash
# Navigate to the program directory
cd Program1-YouTubeVideos

# Run the program
dotnet run

# If doesn't run by uisng the command you can run the project by opening the folder seperately 
```



Repeat for Program2, Program3, and Program4.

## Project Requirements Met

- All programs compile without errors
- All member variables use proper encapsulation (private/protected)
- Proper naming conventions followed (_camelCase for private, TitleCase for public)
- Each program demonstrates its assigned OOP principle
- Code is well-commented and organized
- Programs produce expected output

## Learning Outcomes

Through this project, I demonstrated proficiency in:
- Designing class hierarchies using inheritance
- Implementing polymorphism through method overriding
- Applying encapsulation to protect data
- Using abstraction to simplify complex systems
- Writing clean, maintainable object-oriented code

## Contact

For questions or feedback, please contact me through BYU-Idaho I-Learn.

**Course:** CSE 121C - Programming with Classes  
**Institution:** Brigham Young University - Idaho  
**Semester:** Winter 2026