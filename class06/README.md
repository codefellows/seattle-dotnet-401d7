![cf](http://i.imgur.com/7v5ASc8.png) Class 05
=====================================

## Learning Objectives
1. The student will know the difference between procedural and object oriented programming
2. The student will be introduced and understand the differences between the 4 OOP principles.


## Lecture Outline

### Procedural Programming (imperative programming)
Procedural programming is a list of instructions that tells program what to do step by step.
Procedural relies on a series of computational steps to be carried to completion. This is usuallly done telling 
the program what to do first at the beginning, and what to do at the end. it is a bit more intuitive and simple
to read from top to bottom. Procedural programming languages are also called "top down "

### What is Object Oriented Programming?
Object oriented programming is mimicking real world objects in code. 
Everything in C# is essentially a class, and we can instantiate objects from 
classes that we can manage at a smaller level. 

OOP objects are created to interact with other elements of the program regardless of where the command
is being called from. 

## OOP Principles
Object Oriented Programming (OOP) principles are the fundamentals that help us define objects and use them
within our system. 

### Inheritance

Inheritance is the process by which one class takes on the attributes and methods of another. 
Newly formed classes are called child classes, and the classes that child classes are derived from 
are called parent classes.

It's important to note that child classes override or extend the functionality (e.g., attributes and behaviors) of parent classes. In other words, child classes inherit all of the parent�s attributes and behaviors but can also specify different behavior to follow. The most basic type of class is an object, 
which generally all other classes inherit as their parent.

#### Single Inheritance
When you do single inheritance, you are only passing on one class's behavior onto a derived class. This is 
the most common type of inheritance amongst programming languages. (C# only support single inheritance)


### Abstraction

in OOP - Abstract classes are not supposed to be instantiated. They are only supposed to be used as a template that can be
derived further down for more clarity. 

Abstract classes cannot be instantiated. 

Abstract methods must be overridden. 

### Polymorphism
Poly means many
morph means to change

Within polymorphism, we want the ability to change the behavior of a specific class. We also want to be able to target specific types of classes (classes that are derived from specific classes). Polymorphism also helps us target any and all classes that implement specific interfaces. 

The ability to override an abstract or virtual method is polymorphism. 


### Encapuslation

Encapsulation is the process of hiding implementation details from the user.
Encapsulation is the act of hiding methods and attributes that should not be exposed to unauthorized or unneeded
classes or methods. Examples of encapsulation are Public, private, and protected. 

Access Modifiers: 
1. Public - Everyone has access
2. Private - Only the class has access to it
3. Protected - the class and any of it's derived children have access. 


