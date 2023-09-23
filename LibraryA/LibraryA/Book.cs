namespace LibraryA
{
    public class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public string Genre = string.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages = 300;
        public Book() { Console.WriteLine("Book Obj Created"); }   
        public void OpenBook() 
        {
            Console.WriteLine("Book is Open");
        }
        public void BookMarkPage(int PageNo) 
        {
            Console.WriteLine($"Page No.{PageNo} has been bookmarked");
        }
        public int GetCurrentPage() 
        {
            Random random = new Random();
            return random.Next(TotalPages);
        }
        public void CloseBook()
        {
            Console.WriteLine("Book is closed");
        }

    }
}