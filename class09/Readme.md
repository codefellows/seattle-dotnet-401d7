![cf](http://i.imgur.com/7v5ASc8.png) Class 08: LINQ
=====================================

## Learning Objectives
1. Studetns will be able to succesfully write LINQ queries against a collection to extract data.
1. Students will understand the use of a Lambda statement and how to join them with LINQ queries.
 
## Lecture Outline
- Review Collections
  - Create a collection
  - Add data to the collection
  - iterate through the collection

1. What is an easier way to iterate through a collection?

### What Is LINQ?
- Language Integrated Query

1. Imperative vs Declarative
   1. What is Imperative
      1. Foreach Loop
   1. What is Declarative
      1. LINQ statement

   1. What is a 'query'?
   - A query is an expression that, when enumerated, transforms sequences with query operators. 
   - The standard query operators are implemented as *extension methods*, so we can call 'Where' directly onto names

   1. Query Expresssions 
    ```csharp
	   string[] names = { "Tom", "Dick", "Harry" };

    IEnumerable<string> filteredNames = from n in names
                                        where n.Contains ("a")
                                        select n;

 
    IEnumerable<string> filteredNames = System.Linq.Enumerable.Where
                                        (names, n => n.Length >= 4);
    foreach (string n in filteredNames)
        Console.WriteLine (n);

    Dick
    Harry
```


1. Lambda Statements

    ```csharp
    n => n.Length >= 4
    ```


    ```csharp
    IEnumerable<string> filtered = names.Where(n => n.Contains ("a"));
    IEnumerable<string> sorted = filtered.OrderBy(n => n.Length);
    IEnumerable<string> finalQuery = sorted.Select(n => n.ToUpper());


    foreach (string name in filtered)
      Console.Write (name + "|");        // Harry|Mary|Jay|

    Console.WriteLine();
    foreach (string name in sorted)
      Console.Write (name + "|");        // Jay|Mary|Harry|

    Console.WriteLine();
    foreach (string name in finalQuery)
      Console.Write (name + "|");        // JAY|MARY|HARRYkk|

    ```

   1. Anonymous Objects 
   1. Anonymous Types
      - ```csharp 
         var filteredNames = names.Where (n => n.Length >= 4); 
        ```

        ```csharp
        var bookAuthorCollection = from b in books
                           select new { Book: b,
                                        Author: b.Authors[0]
                                      };
    
        foreach (var x in bookAuthorCollection)
            Console.WriteLine("Book title - {0}, First author {1}", 
                                 x.Book.Title, x.Author.FirstName);
        ```

- We want bookAuthorCollection ot hold information only about the book and author when extracing data
    1. .Where is an example of an extension method.


1. Sub Queries
1. LINQ to Objects

