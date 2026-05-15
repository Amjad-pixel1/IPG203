using LibrarySystem.Models;
using LibrarySystem.Services;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //  إنشاء Manager
            LibraryManager manager = new LibraryManager();

            //  إنشاء عناصر
            var book = new Book("C# Basics", "John Doe", 300);
            var magazine = new Magazine("Tech Monthly", "Jane Smith", 12);
            var dvd = new DVD("OOP Tutorial", "Mike Johnson", 120);

            //  ربط الأحداث
            book.OnItemAction += HandleEvent;
            magazine.OnItemAction += HandleEvent;
            dvd.OnItemAction += HandleEvent;

            //  إضافة العناصر
            manager.AddItem(book);
            manager.AddItem(magazine);
            manager.AddItem(dvd);

            //  عرض العناصر
            Console.WriteLine("=== Library Items ===");
            manager.DisplayAllItems();

            //  إعارة عنصر
            Console.WriteLine("\n=== Borrow Item ID 1 ===");
            manager.BorrowItem(1);

            //  محاولة إعادة الإعارة
            Console.WriteLine("\n=== Borrow Again ===");
            manager.BorrowItem(1);

            //  إرجاع
            Console.WriteLine("\n=== Return Item ID 1 ===");
            manager.ReturnItem(1);

            //  عرض العدد الإجمالي
            Console.WriteLine($"\nTotal Items: {LibraryItem.Count}");
        }

        //  دالة التعامل مع الحدث
        static void HandleEvent(string message)
        {
            Console.WriteLine($"[EVENT]: {message}");
        }
    }
}