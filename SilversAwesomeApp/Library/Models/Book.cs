using System;

namespace Library.Models
{
    public class Book : ILibraryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LibraryType Type { get; set; }
        public DateTime BoughtWhen { get; set; }
        public bool Available { get; set; }
        public string DisplayMember => $"{Name} ({Available})";
    }
}