![cf](http://i.imgur.com/7v5ASc8.png) Class 12
=====================================

## Learning Objectives
1. Students will create their own Database Schema given a problem domain
2. Students will learn and apply the differences between primary keys, foreign key, and composite keys.
3. The students will know the difference between a relational and non-relational database. 

## Lecture Outline

## What is a Database

### Different Kinds of Databases
	1. Relational
		- SQL Server
	2. Non-Relational
		- SQLLite

### Relational vs Non-Relational

1. Relational
	- Relational databases are databases where each table can hold a relationship with another. This is usually done through some sort of unique identifier that can require a row of each table to stay unique even after the many different transactions that process through. This allows for separation of concerns within a database and ability to manipulate individual parts of a grouped together information

2. Non-Relational
	- Non Relational databases don't depend on relationships or keys between tables. NoSQL is an example, and all the information is stored in one "document" that makes it potentially easier to group together information without having to join tables. 
	Examples: Big Data, and Real Time Applications

## Representation
We can represent a relational database through a database schema. 
	
	1. 1:1
	2. Many:Many
	3. 1:Many
	4. Many:1

### Keys
	1. Primary Keys
	2. Foreign Keys
	3. Composite Keys (New!)

1. Primary Keys
	 - Unique identifier for a specific table. Usually named `Id`.
	 - Each row of the table will have it's own unique primary key.
2. Foreign Key
	- Unique identifier from another table.
	- Often used to join tables within a query and associate table data. 
	- Naming convention is the name of the table plus the word Id. Example: BookId is a foreign key in the Library Table. In the Book table, it is simply `Id`. 
3. Composite Key
	- A combination of columns that make up a unique identifier for a table
	- Composite keys usually consist of multiple foreign keys combined together. No Primary key needs to be included in the combination. 
	- You do not necessarily need to include a primary key in a table that utilizes a composite key.

### Create a Database Schema

Together, In class, create a database schema given a problem domain. 