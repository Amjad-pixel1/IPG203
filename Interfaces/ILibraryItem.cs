namespace LibrarySystem.Interfaces
{
	public interface ILibraryItem
	{
		string Title { get; }
		string Author { get; }

		void DisplayInfo();
		void BorrowItem();
		void ReturnItem();
	}
}