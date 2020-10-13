using System;

namespace LibraryContracts
{
    public interface BorrowBook   
    {
        string Title { get; }
        string Author { get; }
        string Content { get; }
    }

    public interface Accepted
    {
        TimeSpan TimeStamp { get; }
    }
}