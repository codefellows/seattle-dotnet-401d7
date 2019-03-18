![cf](http://i.imgur.com/7v5ASc8.png) Class 03
=====================================

## Learning Objectives
1. The student will be introduced and implement the FileStream.
2. The student will know how to Create, Read, Update, and Delete file using the FileStream.
3. The student will know how to properly open and close a file from an external location.

## Lecture Outline

### System IO Library
 - What is it
 - Why do we use it

#### Writing a file

```csharp
string myInfo = "I want to write all of this to a file";
File.WriteAllText("/path/to/file.txt", myInfo);
```


```csharp
string[] myArray = new string[2];
myArray[0] = "My first line of information";
myArray[1] = "My second line of information";

File.WriteAllText("/path/to/file.txt",myArray);
```

#### Reading a file

 ```csharp
string[] myFile = File.ReadAllLines("/path/to/file.txt");
```

```csharp
string myFile = File.ReadAllText("/path/to/file.txt");
```

#### Creating a file
(Check out the demo. There are 2 different ways to achieve this!)

#### Deleting a file

To delete a file, just tell the library to delete the location by inputting the path. 

```csharp
File.Delete(path);
```


## File Stream
 - What is a stream
	1. StreamReader
	2. StreamWriter

## File Types
- CSV
- Text
- Binary
