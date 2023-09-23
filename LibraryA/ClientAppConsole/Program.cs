using LibraryA;
Book book = new Book();
book.Title = "To kill A MockingBird";
book.Author = "Harper Lee";
book.Genre = "Social";
book.BookPrice = 250;
book.DateOfPublish = new DateTime(1995, 06, 01);
book.BookMarkPage(125);
Console.WriteLine(book.GetCurrentPage());
Calculator c = new Calculator();
Console.WriteLine("Add Result = "+c.Add(1,2));
Console.WriteLine("Multiply Result = "+c.Multiply(2,2));
Console.WriteLine("Divide Result = "+c.Divide(12345678,2));


