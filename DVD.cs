namespace LibrarySystem.Models
{
    public class DVD : LibraryItem
    {
        public int Duration { get; }

        public DVD(string title, string author, int duration)
            : base(title, author)
        {
            Duration = duration;
        }

        public override void GetItemType()
        {
            Console.WriteLine("Type: DVD");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Duration: {Duration} minutes");
        }
    }
}