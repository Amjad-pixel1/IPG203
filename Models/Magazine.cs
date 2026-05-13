namespace LibrarySystem.Models
{
	public class Magazine : LibraryItem
	{
		public int IssueNumber { get; }

		public Magazine(string title, string author, int issueNumber)
			: base(title, author)
		{
			IssueNumber = issueNumber;
		}

		public override void GetItemType()
		{
			Console.WriteLine("Type: Magazine");
		}

		public override void DisplayInfo()
		{
			base.DisplayInfo();
			Console.WriteLine($"Issue: {IssueNumber}");
		}
	}
}