using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    public class LibraryManager
    {
        private List<LibraryItem> _items = new List<LibraryItem>();

        //  ÅÖÇÝÉ ÚäÕÑ
        public void AddItem(LibraryItem item)
        {
            _items.Add(item);
        }

        //  ÚÑÖ ÌãíÚ ÇáÚäÇÕÑ
        public void DisplayAllItems()
        {
            foreach (var item in _items)
            {
                item.GetItemType();     // Polymorphism
                item.DisplayInfo();     // Polymorphism
                Console.WriteLine("-------------------");
            }
        }

        //  ÅÚÇÑÉ ÚäÕÑ ÍÓÈ ID
        public void BorrowItem(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                item.BorrowItem();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        //  ÅÑÌÇÚ ÚäÕÑ
        public void ReturnItem(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                item.ReturnItem();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
    }
}