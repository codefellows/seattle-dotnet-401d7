![cf](http://i.imgur.com/7v5ASc8.png) Class 04: Classes and Objects
=====================================

## Learning Objectives
1. Students will be introduced to Object Oriented Programming
2. Students will know the difference between a class and an object
3. Students will know the difference between the stack and the heap. 
4. Students will be introduced to Garbage Collection and it's purpose.

## Lecture Outline

### Object-Oriented Programming
- What is Object Oriented Programming?

Object oriented programming is mimicking real world objects in code. 
Everything in C# is essentially a class, and we can instantiate objects from classes that we can manage at a smaller level.

### Classes
- We've seen them, now how do we use them?

A class is a blueprint for a specific type or category of object. 
This means that the class will outline what exactly each object will have in regards to 
properties, methods, and general behavior. 

### Objects
- What is the difference between a class and an object??
	- An object is an **instance of a class**

- To create an object, we must instantiate it from a non-abstract class. 

### Constructors
Constructors are created by default with each class. They are the "requirements" of what information is required before an object can be instantiated. we have the ability to add more than one constructor if needed. By default, we get an "empty" one. if we decide to create a new constructor, we must explicitly declare an empty constructor for it to be used. 

### Object Initializers
- We can initialize an object on creation. This saves space when coding, and sometimes looks a little cleaner. 

### Keyword Static
- What does static mean?
	- if it is marked as static, it lives at the class level, not the object level.
