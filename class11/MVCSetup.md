# Default MVC Application

Below are the directions to scaffold out a bare minimum MVC project for class 11. Each project you create will be different given the problem domain, but most of them should start with these steps to get started. 

### Set up MVC
1. File >> New Project
2. ASP.NET Core Web Application
3. Create a project name (Do not use dashes, only use underscores if needed)
4. Select Empty for the type of web application.
5. Leave everything else as is, and select OK.
6. Go to Startup.cs
7. In `ConfigureServices()` add the appropriate middleware `services.AddMVC()`
8. In `Configure()` add HTTP Pipeline route requirements

```
app.UseMvc(routes =>
{
	routes.MapRoute(
	name: "default",
	template: "{controller=Home}/{action=Index}/{id?}");
});
```

9. Add app.UseStaticFiles() under `Configure()` after mapping the route to allow the use of static files, such as css and js files.
10. Create a new folder in the project called "Controllers"
11. Create a new folder in the project called "Models"
12. Create a new folder in the project called "Views"
13. If needed, Create a new folder named `wwwroot`
14. Create a new class named `HomeController` in the Controllers Folder
15. Derive `HomeController` from base class Controller (`HomeController:Controller`)
16. Import the appropriate namespace (`Microsoft.AspNetcore.MVC`)
17. Create new action in HomeController named "Index" with a return type of IActionResult
18. Make the return of the `Index()` action `return View()`

```csharp
  public IActionResult Index()
  {
     return View();
  }
```

19. Create a new folder named "Home" in our Views Folder.
20. Create a new .cshtml page in the Home folder that you just created
	a. Right click on Home Folder
	b. Add -> New Item ->
	c. search for "View" 
	d. select "Razor View"
	e. Name the View the same page as your action (Keep it Index for this example)
21. Add Text to your Index.cshtml file
22. Run the app and make sure it loads your Home page.
23. If it runs -> YAAY!, if not troubleshoot steps 1-21.

### Next Steps

Your next steps are to add the appropriate additional routes and view pages given the problem domain of the lab.
