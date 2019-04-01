![cf](http://i.imgur.com/7v5ASc8.png) Lab 13: Async Inn Management System
=====================================

## To Submit this Assignment
- Create a new repo on your personal GitHub account
- Name your repo `AsyncInn`
- Create a branch named `NAME-LAB13`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `master` branch.
- Submit a link to your PR in canvas
- Merge your PR back into master
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described below)

## The Problem Domain
Now that you have a solid understanding of your database schema for your hotel management system, today you will build from scratch the initial .NET Core MVC structure and application.


## Application Specifications
- Your application should include the following:
1. Startup File
	 - Explicit routing of MVC 
	 - MVC dependency in ConfigureServices
	 - DBContext registered in ConfigureServices
	 - Use of static files accepted
2. Controller
	 - Home Controller
	 - Controllers  for each of the pages described in the Design section (you may choose to scaffold or build controllers/views from scratch)
3. Data
	- DBContext present and properly configured
	- DB Tables for each entity model (`DbSet<T>`)
	- Composite key association present in `OnModelCreating` override.
	- `appsettings.json` file present with name of database updated

4. Models
	- Each Entity from the DB Table converted into a Model
	- Proper naming conventions of Primary keys
	- Navigation properties present in each Model where required
	- Enum present in appropriate model

5. Views
	- View for home page that matches default routing

5. Home Page
	- stylesheet present in web application
	- stylesheet referenced on home page.

6. Web application should build, compile, and redirect us to the home page upon launch. If you decided to scaffold the controllers, they should be accessible through their default actions. 


## Guidance
Create a basic MVC web application using the steps provided from class 11 & 12. Include a Home Controller with a basic Index action. No need to add any content to the Index view, just have it load a greeting for now. You will work more on the Home Controller a little further down.
Using your database schema, convert each entity into a model within your newly created MVC web application.

Following the steps provided, in addition to what we did in class, create a new `DbContext` named `AsyncInnDbContext`. 
Within this DbContext, declare your Database tables and set your composite keys. 

##### Design
Think about the design of your website. What will it look like? What pages will exist? How do the pages interact and link to each other? For our website, we will have the following pages:
1. Home Page to greet the Hotel Admin. This page will also serve as a dashboard for the other locations of the site.
2. Hotels page that will allow the Admin to create and edit new or existing hotels
3. Rooms page where the Admin will be able to create or edit new or existing rooms
4. Amenities page that will allow the Admin to add to their list of existing amenities
5. A page where they can link the Amenities to the rooms that currently exist
6. A page where they can add existing rooms to hotels

Following the design, Create a controller for each of the pages listed above. You may "Add >> Controller" on the controllers folder and scaffold out the basic CRUD operations if you wish. 

##### Home Page
Add some HTML and styling to your home page. Link the index action of each of the other controllers within the Home page. Throughout the week, we will slowly evolve this page to be more of a "dashboard" feel, but start the design now to start the process. 

##### README
Your README should be in introduction to your web app. Provide in your README, your DbSchema and an overview of the relationships and how each entity is related to another. 


## Tests
- There are no Unit Tests required for this assignment.

I **strongly** encourage you to research how to write tests for a .NET Core MVC application. Attempt to write some tests, as they will eventually be required.  Research, start here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing){:target="_blank"}. 


## Stretch Goals
- There are no Stretch Goals for this assignment.


## Additional Resources
- Setup default MVC [20 simple steps](https://github.com/codefellows/code-401-dotnet-guide/blob/master/Curriculum/Class11/Resources/MVCSetup.md){:target="_blank"}


## README

**A README is a requirement. No README == No Grade.** <br /> 
Here are the requirements for a valid README: <br />


A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context, provide a summary)
2. show them what it looks like in action (Visuals)
3. show them how they use it (Step by step directions, "Happy Path" walk through)
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [sample-README](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric
- 7pts: Program meets all requirements described in Lab directions.

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	7       | Program runs as expected, no exceptions during execution |
	5       | Program meets all of the  functionality requirements described above (including tests) // Program runs/compiles, Program contains logic/process errors|
	4       | Program meets most of the functionality requirements described above (including tests)  // Program runs/compiles, but throws exceptions during execution |
	3       | Program missing most of the functionality requirements described above // Program runs/compiles |
	2       | README Document does not meet minimum standards |
	0       | Program does not compile/run. Build Errors // Required naming conventions not met |
	0       | No Submission |

- 3pts: Code meets industry standards
	- These points are only awardable if you score at minimum a 5/7 on above criteria

	Points  | Reasoning | 
	 ------------ | :-----------: | 
	3       | Code meets Industry Standards // methods and variables namings are appropriate // Selective and iterative statements are used appropriately, Fundamentals are properly executed // Clearly and cleanly commented |
	2       | syntax for naming conventions are not correct (camelCasing and PascalCasing are used appropriately) // slight errors in use of fundamentals // Missing some comments |
	1       | Inappropriate naming conventions, and/or inappropriate use of fundamentals // Code is not commented  |
	0       | No Submission or incomplete submission |



