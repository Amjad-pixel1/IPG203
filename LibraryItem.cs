using LibrarySystem.Interfaces;
using LibrarySystem.Utilities;

namespace LibrarySystem.Models
{
    public abstract class LibraryItem : ILibraryItem
    {
        //  Delegate
        public delegate void ItemActionHandler(string message);

        //  Event
        public event ItemActionHandler? OnItemAction;

        //  Encapsulation
        private string _title;
        private string _author;
        private bool _isBorrowed;

        //  Property ··ﬁ—«¡… ›ﬁÿ
        public string Title => _title;
        public string Author => _author;
        public bool IsBorrowed => _isBorrowed;

        //  ID ·« Ì €Ì— 
        public int Id { get; }

        //  Static counter
        private static int _count = 0;

        public static int Count => _count;

        //  Constructor
        public LibraryItem(string title, string author)
        {
            if (!Validator.IsValidString(title))
                throw new ArgumentException("Invalid title.");

            if (!Validator.IsValidString(author))
                throw new ArgumentException("Invalid author.");

            _title = title;
            _author = author;

            _count++;
            Id = _count;
        }

        //  œÊ«· „‘ —ﬂ…
        public void BorrowItem()
        {
            if (_isBorrowed)
            {
                Console.WriteLine($"Item '{Title}' is already borrowed.");
                return;
            }

            _isBorrowed = true;
            string message = $"Item '{Title}' borrowed.";

            Console.WriteLine(message);
            OnItemAction?.Invoke(message);
        }

        public void ReturnItem()
        {
            if (!_isBorrowed)
            {
                Console.WriteLine($"Item '{Title}' is not borrowed.");
                return;
            }

            _isBorrowed = false;
            string message = $"Item '{Title}' returned.";

            Console.WriteLine(message);
            OnItemAction?.Invoke(message);
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {Author}");
        }

        //  œ«·… „Ã—œ… 
        public abstract void GetItemType();
    }
}