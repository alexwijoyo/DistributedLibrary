namespace Library.OnPlatform
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Content { get; }

        public Book(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }
    }
}