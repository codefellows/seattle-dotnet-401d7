![cf](http://i.imgur.com/7v5ASc8.png) Class 01: Intro to C#
=====================================

## Learning Objectives
1. The student will successfully request user input and output a response to the console.
2. The student will implement try-catch statements as a form of exception handling within their code.
3. Set-up a debugger within Visual Studio 2017.
4. Understand and be comfortable with debugging through code to identify potential bugs and errors. 

## Lecture Outline

## NOTES
<!--Place any pre-lecture notes here . Examples include
1. Class Expectations
2. Syllabus 
3. Career Coaching/DSA 
4. misc..-->

### Welcome to 401: Advanced Software Development in ASP.NET MVC Core
Welcome to Class! Please be sure read through the syllabus and get comfortable with both Visual Studio and Canvas.
Introduce yourself to your classmates, and come to class ready to learn!

### C# Basics
* What is C#
  * Where did it come from?
	* Currently on C# 7
		* Updates to the language are always in the works to make it better
* What is .NET
* What is ASP.NET
* What is ASP.NET Core
	
* Why do we use it?
	* Statically Typed
		- Type checking occurs at compile time (C#)
	* Dynamically Typed
		- Type checking occurs at Run time (JS)
	* Object Oriented

### Microsoft Platform:
  * C# depends on a runtime equipped with a host of features such as automatic memory management and exception handling. 
  The design of C# closely maps to the design of Microsoft’s Common Language Runtime (CLR), which provides these runtime 
  features (although C# is technically independent of the CLR).
  * The CLR is the runtime for executing managed code. C# is one of several managed languages that get compiled into managed code. 
  Managed code is packaged into an assembly, in the form of either an executable file (an .exe) or a library (a .dll), 
  along with type information, or meta-data.
  * Managed code is represented in intermediate language or IL. When the CLR loads an assembly, it converts the IL into the 
  native code of the machine, such as x86. This conversion is done by the CLR’s JIT (just-in-time) compiler. An assembly retains 
  almost all of the original source language constructs, which makes it easy to inspect and even generate code dynamically.
  * CLR is in charge of taking the managed code, compiling it into machine code and then executing it. 
  On top of that, runtime provides several important services such as automatic memory management, security boundaries, 
  type safety etc.


### Exception Handling

- What is Exception Handling?
- Why do we use it?
- What does it consist of? 
	- try{}
	- catch{}
	- finally{}
	- throw


```csharp
    int zero = 0;    
    
    try
    {
        int result = 5/zero;  // this will throw an exception       
            
    }
    catch(Exception ex)
    {
        Console.WriteLine("Inside catch block. Exception: {0}", ex.Message );
    }
    finally
    {
        Console.WriteLine("Inside finally block.");

    }
```

### Different types of Exceptions:

There are many different types of exceptions included in the C# language. Here is just a few...

1. **NotImpelemtedException** - Indicates that a method has not yet been implemented. 
1. **IndexOutOfRangeException** - Indicates that an index outside the range of a collection has been referenced
1. **InvalidCastException** -  Indicates that a cast has been attempted on the incorrect object type
1. **FormatException** - Text was not in the correct format when converting it to something else.
1. **NotSupportedException** - An action was attempted that was not supported.
1. **NullReferenceException** - Reference type was null, instead of an object
1. **StackOverflowException** - Indicates that there is no more room left on the call stack. 
1. **DivideByZeroException** - You can't divide by zero....
1. **ArgumentNullException** - A required non-null argument provided was null.
1. **ArguementOutOfRangeException** - Argument contained a value that was out of range then what it was expecting. 


### Debugging

- Why do you need debugging?
- How do you debug in Visual Studio?
	- Step over
	- step into
	- step through


## Error Handling while during Lab:
   - What do you do if you encounter an error (whiteboard // draw it)
   - 15 min rule
   - Take a deep breath, step away, break it down
   - documentation
   - look at the lecture
   - Online Research
   - ask a TA
   - Ask the instructor
