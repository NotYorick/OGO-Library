using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library
{
    public class LibraryFactory
    {
        private readonly List<ILibraryItem> _libraryItems;

        public LibraryFactory(string connectionString)
        {
            _libraryItems = new List<ILibraryItem>()
            {
                new Book()
                {
                    Available = true,
                    BoughtWhen = DateTime.Today,
                    Name = "Ormbulle",
                    Type = LibraryType.Book
                },
                new Book()
                {
                    Available = false,
                    BoughtWhen = DateTime.Today,
                    Name = "Silvers Amazing story",
                    Type = LibraryType.Book
                },
                new Book()
                {
                    Available = true,
                    BoughtWhen = DateTime.Today,
                    Name = "Snakes on the plane",
                    Type = LibraryType.Book
                }
            };
        }

        public IEnumerable<ILibraryItem> GetAvailableItems()
        {
            return _libraryItems.Where(li => li.Available).ToList();
        }

        public IEnumerable<ILibraryItem> GetAllItems()
        {
            return _libraryItems.ToList();
        }

        public bool BorrowItem(int id)
        {
            var libraryItem = _libraryItems.FirstOrDefault(li => li.Id == id && li.Available);
            if (libraryItem == null) return false;

            libraryItem.Available = false;
            return true;
        }

        public bool ReturnItem(int id)
        {
            var libraryItem = _libraryItems.FirstOrDefault(li => li.Id == id && !li.Available);
            if (libraryItem == null) return false;

            libraryItem.Available = true;
            return true;
        }

        public ILibraryItem GetItemById(int id)
        {
            return _libraryItems.First(li => li.Id == id);
        }
    }
}
