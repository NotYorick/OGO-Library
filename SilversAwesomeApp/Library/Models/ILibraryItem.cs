using System;

namespace Library.Models
{
    public interface ILibraryItem
    {
        int Id { get; set; }
        string Name { get; set; }
        LibraryType Type { get; set; }
        DateTime BoughtWhen { get; set; }
        bool Available { get; set; }

        string DisplayMember { get; }
    }
}