namespace LibrarySystem.Models
{
    public class Book : LibraryItem
    {
        public int Pages { get; }

        public Book(string title, string author, int pages)
            : base(title, author)
        {
            Pages = pages;
        }

        public override void GetItemType()
        {
            Console.WriteLine("Type: Boook");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Pages: {Pages}");
        }
    }
}