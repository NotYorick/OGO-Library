using System;

namespace Library.Models
{
    public class BorrowedObject
    {
        public string Name { get; set; }
        public DateTime Borrowedwhen { get; set; }
        public TimeSpan BorrowSpan { get; set; }
        public DateTime ReturnWhen => Borrowedwhen + BorrowSpan;
        public ILibraryItem Item { get; set; }
    }
}