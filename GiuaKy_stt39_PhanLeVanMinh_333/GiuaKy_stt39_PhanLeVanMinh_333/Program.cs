using System.Text;

namespace GiuaKy_stt39_PhanLeVanMinh_333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<Document> documents = new List<Document>();
            documents.Add(new Book { Id = 1, Name = "Lập trình C", Publisher = "UTE", CateId = 1, Author = "Author UTE", PageNumber = 200 });
            documents.Add(new Book { Id = 2, Name = "Lập trình C#", Publisher = "UTE", CateId = 1, Author = "Author CNS", PageNumber = 300 });
            documents.Add(new Book { Id = 3, Name = "Lập trình Java", Publisher = "UTE", CateId = 1, Author = "Author CNS", PageNumber = 100 });

            documents.Add(new Magazine { Id = 1, Name = "Tạp chí thời trang", Publisher = "Thời Trang ", CateId = 2, IssueNumber = 10, ReleasePage = "Thời Trang" });
            documents.Add(new Magazine { Id = 2, Name = "Tạp chí nghệ thuậ", Publisher = "Nghệ thuật", CateId = 2, IssueNumber = 10, ReleasePage = "Nghệ thuật" });
            documents.Add(new Magazine { Id = 3, Name = "Tạp chí khoa học", Publisher = "Khoa Học", CateId = 2, IssueNumber = 10, ReleasePage = "Khoa Học" });

            documents.Add(new Newspaper { Id = 1, Name = "Thanh Niên", Publisher = "Thanh Niên", CateId = 3, ReleaseDate = new DateTime(2024, 3, 20) });
            documents.Add(new Newspaper { Id = 2, Name = "Tuổi trẻ", Publisher = "Kim Đồng", CateId = 6, ReleaseDate = new DateTime(2024, 4, 1) });
            documents.Add(new Newspaper { Id = 3, Name = "Lao động", Publisher = "Lao động", CateId = 6, ReleaseDate = new DateTime(2024, 1, 1) });

            var books = documents.OfType<Book>().ToList();
            var magazines = documents.OfType<Magazine>().ToList();
            var newspapers = documents.OfType<Newspaper>().ToList();

            Console.WriteLine("\n<<<<<<<< Kiem tra giua ky - Phan Le Van Minh - 21115053120333 >>>>>>>:");
            while (true)
            {
                Console.WriteLine("\nChọn danh mục để tìm kiếm:");
                Console.WriteLine("1. Books");
                Console.WriteLine("2. Magazines");
                Console.WriteLine("3. Newspapers");
                Console.WriteLine("4. Tìm kiếm Newspaper theo tháng");
                Console.WriteLine("Q.Thoát");

                Console.WriteLine("\nNhập lựa chọn của bạn!");
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Danh sách Books:");
                        foreach (var book in books)
                        {
                            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Author: {book.Author}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Danh sách Magazines:");
                        foreach (var magazine in magazines)
                        {
                            Console.WriteLine($"Id: {magazine.Id}, Name: {magazine.Name}, Issue Number: {magazine.IssueNumber}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Danh sách Newspapers:");
                        foreach (var newspaper in newspapers)
                        {
                            Console.WriteLine($"Id: {newspaper.Id}, Name: {newspaper.Name}, Release Date: {newspaper.ReleaseDate:d}");
                        }
                        break;

                    case "4":
                        Console.Write("Nhập tháng (1-12): ");
                        if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
                        {
                            var newspapersInMonth = newspapers.Where(n => n.ReleaseDate.Year == 2024 && n.ReleaseDate.Month == month).ToList();
                            if (newspapersInMonth.Count > 0)
                            {
                                Console.WriteLine($"Danh sách Newspapers trong tháng {month}/2024:");
                                foreach (var newspaper in newspapersInMonth)
                                {
                                    Console.WriteLine($"Id: {newspaper.Id}, Name: {newspaper.Name}, Release Date: {newspaper.ReleaseDate:d}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Không có Newspapers trong tháng {month}/2024.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nhập tháng không hợp lệ.");
                        }
                        break;

                    case "Q":
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
