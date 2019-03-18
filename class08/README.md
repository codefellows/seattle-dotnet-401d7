![cf](http://i.imgur.com/7v5ASc8.png) Class 07: Collections
=====================================

## Learning Objectives
1. The student will understand and implement their own enums into their programs and classes.
2. The student will be able to identify and implement their own generic collection.

## Lecture Outline

#### Overview:
1. Review the coding challenge from the previous day, this will directly tie into today's lecture.
2. We will go over both generic and non-generic, but they will be implementing their own generic collection as their lab assignment.

### Enums

1. What are enums?
   1. Enumeration types ("also called enums"), provide an 
   efficient way to define a set of named integral constants that may be assigned 
   to a variable. 

   ```csharp
            enum Days 
            { 
                Sunday,
                Monday, 
                Tuesday, 
                Wednesday, 
                Thursday, 
                Friday, 
                Saturday 
            };

            enum Months : byte 
            { 
                Jan, 
                Feb, 
                Mar, 
                Apr, 
                May, 
                Jun, 
                Jul, 
                Aug, 
                Sep, 
                Oct, 
                Nov, 
                Dec 
            }; 
   ```
        - Count starts at 0, if you do not specify a value. 
        - default type of enum is int, but you can specify alt with a :type (such as byte);

            ```csharp
            Days today = Days.Monday;  
            int dayNumber =(int)today;  
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);  

            Months thisMonth = Months.Dec;  
            byte monthNumber = (byte)thisMonth;  
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);  

            // Output:  
            // Monday is day number #1.  
            // Dec is month number #11.  

            ```

            - You can create and set your custom values

            ```csharp
            enum MachineState
            {
                PowerOff = 0,
                Running = 5,
                Sleeping = 10,
                Hibernating = Sleeping + 5
            }

            ```

### Collections

There are two ways to create and manage a group of related objects
    1. Create an array of objects
    2. creating a collection of objects


A collection is a class, so you must declare an instance of the class before you can add elements to that collection.


