using System;


// class Program
// {
//     static void Swap<T>(ref T a, ref T b)
//     {
//         T temp = a;
//         a = b;
//         b = temp;
//     }
//
//     static void Main(string[] args)
//     {
//         int x=1, y=0;
//         Console.WriteLine($"До: x= {x}, y= {y}");
//         Swap<int>(ref x, ref y);
//         Console.WriteLine($"После: x= {x}, y= {y}");
//         
//     }
// }



// namespace Practica
//
// {
//     public static class Proverka
//     {
//         public static bool Nechetne(this int number)
//         {
//             return number % 2 != 0;
//         }
//         public static bool Chetne(this int number)
//         {
//             return number % 2 == 0;
//         }
//     }
//
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int num = 2;
//             int num2 = 1;
//             Console.WriteLine($"{num} четное: {num.Chetne()}");
//             Console.WriteLine($"{num} не четное: {num.Nechetne()}");
//             Console.WriteLine($"{num2} четное: {num2.Chetne()}");
//             Console.WriteLine($"{num2} не четное: {num2.Nechetne()}");
//         }
//     }
// }












//задание 1
// namespace Practica
// {
//     public class Sotrydnik
//     {
//         public string FIO { get; set; }
//         public string Position { get; set; }
//         public decimal ZP { get; set; }
//         public string Email { get; set; }
//         public override string ToString()
//         {
//             return $"Фио: {FIO}, Должность: {Position}, ЗП: {ZP}, Почта: {Email}";
//         }
//     }
//
//     class Program
//     {
//          static List<Sotrydnik> sotrydniks = new List<Sotrydnik>
//         {
//             new Sotrydnik{FIO = "Tom Tomas",Position = "SMM",ZP = 30000,Email = "tomas@gmail.com"},
//             new Sotrydnik{FIO = "Dima Ivanov",Position = "Designer",ZP = 60000,Email = "ivanov@gmail.com"}
//
//         };
//         static void Main(string[]args)
//         {
//             while (true)
//             {
//                 Console.WriteLine("1) Добавление сотрудников");
//                 Console.WriteLine("2) Удаление сотрудников");
//                 Console.WriteLine("3) Изменение информации о сотрудниках");
//                 Console.WriteLine("4) Поиск сотрудников по параметрам");
//                 Console.WriteLine("5) Сортировка сотрудников по параметрам");
//                 Console.WriteLine("Выберите: ");
//                 string choice = Console.ReadLine();
//                 switch (choice)
//                 {
//                     case "1": AddSotrydnik();
//                         break;
//                     case "2" : RemoveSotrydnik();
//                         break;
//                     case "3" : EditSotrydnik();
//                         break;
//                     case "4": SearchSotrydnik();
//                         break;
//                     case "5": SortSotrydnik();
//                         break;
//                 }
//             }
//         }
//
//         static void AddSotrydnik()
//         {
//             Sotrydnik sotrydnik = new Sotrydnik();
//             Console.Write("ФИО: ");
//             sotrydnik.FIO = Console.ReadLine();
//             Console.Write("Position: ");
//             sotrydnik.Position = Console.ReadLine();
//             Console.Write("ZP: ");
//             sotrydnik.ZP = decimal.Parse(Console.ReadLine());
//             Console.Write("Email: ");
//             sotrydnik.Email = Console.ReadLine();
//             sotrydniks.Add(sotrydnik);
//             Console.WriteLine("Сотрудник добавлен");
//             Show();
//
//         }
//
//         static void Show()
//         {
//             if (sotrydniks.Any())
//             {
//                 foreach (var sotrydnik in sotrydniks)
//                 {
//                     Console.WriteLine(sotrydnik);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Никого нету");
//             }
//         }
//
//         static void RemoveSotrydnik()
//         {
//             Console.Write("Введите ФИО: ");
//             string name = Console.ReadLine();
//             Sotrydnik sotrydnik = sotrydniks.FirstOrDefault(e => e.FIO.Equals(name, StringComparison.OrdinalIgnoreCase));
//             if (sotrydnik != null)
//             {
//                 sotrydniks.Remove(sotrydnik);
//                 Console.WriteLine("Сотрудник удален");
//             }
//             else
//             {
//                 Console.WriteLine("Сотрудник не найден");
//             }
//             Show();
//         }
//
//         static void EditSotrydnik()
//         {
//             Console.Write("ФИО сотрудника для изменения: ");
//             string name = Console.ReadLine();
//             Sotrydnik sotrydnik = sotrydniks.FirstOrDefault(e => e.FIO.Equals(name, StringComparison.OrdinalIgnoreCase));
//             if (sotrydnik != null)
//             {
//                 Console.Write("New FIO: ");
//                 string newFIO = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newFIO)) sotrydnik.FIO = newFIO;
//
//                 Console.Write("New Position: ");
//                 string newPosition = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newPosition)) sotrydnik.Position = newPosition;
//
//                 Console.Write("New ZP: ");
//                 string newZP = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newZP)) sotrydnik.ZP = decimal.Parse(newZP);
//
//                 Console.Write("New Email: ");
//                 string newEmail = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newEmail)) sotrydnik.Email = newEmail;
//
//                 Console.WriteLine("Информация обновлена");
//             }
//             else
//             {
//                 Console.WriteLine("Сотрудник не найден");
//             }
//             Show();
//         }
//         static void SearchSotrydnik()
//         {
//             Console.Write("Введите ФИО для поиска: ");
//             string poisk = Console.ReadLine();
//             var results = sotrydniks.Where(e => e.FIO.Contains(poisk, StringComparison.OrdinalIgnoreCase)).ToList();
//             if (results.Any())
//             {
//                 Console.WriteLine("Найденные сотрудники:");
//                 foreach (var s in results)
//                 {
//                     Console.WriteLine(s);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Сотрудники не найдены");
//             }
//         }
//
//         static void SortSotrydnik()
//         {
//             Console.WriteLine("Что сортировать: \n 1 - FIO\n 2 - Position\n 3 - ZP ");
//             string choice = Console.ReadLine();
//             switch (choice)
//             {
//                 case "1": sotrydniks = sotrydniks.OrderBy(e => e.FIO).ToList();
//                     break;
//                 case "2": sotrydniks = sotrydniks.OrderBy(e => e.Position).ToList();
//                     break;
//                 case "3": sotrydniks = sotrydniks.OrderBy(e => e.ZP).ToList();
//                     break;
//             }
//             Console.WriteLine("Сортировка выполнена");
//             Show();
//         }
//
//     }
//     
// }








//задание 2


// namespace Practica
// {
//     public class Book
//     {
//         public string Title { get; set; }
//         public string Author { get; set; }
//         public string Genre { get; set; }
//         public int Year { get; set; }
//
//         public override string ToString()
//         {
//             return $"Название: {Title}, Автор: {Author}, Жанр: {Genre}, Год: {Year}";
//         }
//     }
//
//     class Program
//     {
//         static LinkedList<Book> books = new LinkedList<Book>(new[]
//         {
//             new Book{ Title = "Гордость и предубеждение",Author = "Джейн Остин",Genre = "роман",Year = 1813},
//             new Book{ Title = "Властелин колец: Братство Кольца",Author = "Дж. Р. Р. Толкин",Genre = "фэнтези",Year =1954}
//
//         });
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.WriteLine("1) Добавить книгу");
//                 Console.WriteLine("2) Удалить книгу");
//                 Console.WriteLine("3) Изменить информацию о книге");
//                 Console.WriteLine("4) Найти книгу");
//                 Console.WriteLine("5) Вставить книгу в начало списка");
//                 Console.WriteLine("6) Вставить книгу в конец списка");
//                 Console.WriteLine("7) Вставить книгу в определённую позицию");
//                 Console.WriteLine("8) Удалить книгу из начала списка");
//                 Console.WriteLine("9) Удалить книгу из конца списка");
//                 Console.WriteLine("10) Удалить книгу из определённой позиции");
//                 Console.Write("Выберите: ");
//                 string choice = Console.ReadLine();
//
//                 switch (choice)
//                 {
//                     case "1": AddBook();
//                         break;
//                     case "2": RemoveBook();
//                         break;
//                     case "3": EditBook(); 
//                         break;
//                     case "4": SearchBooks();
//                         break;
//                     case "5": AddBookToStart(); 
//                         break;
//                     case "6": AddBookToEnd();
//                         break;
//                     case "7": AddBookToPosition(); 
//                         break;
//                     case "8": RemoveBookFromStart();
//                         break;
//                     case "9": RemoveBookFromEnd();
//                         break;
//                     case "10": RemoveBookFromPosition();
//                         break;
//                 }
//             }
//         }
//         static void AddBook()
//         {
//             Book book = CreateBook();
//             books.AddLast(book);
//             Console.WriteLine("Книга добавлена");
//             ShowBooks();
//         }
//
//         static void RemoveBook()
//         {
//             Console.Write("Введите название книги: ");
//             string title = Console.ReadLine();
//             var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
//             if (book != null)
//             {
//                 books.Remove(book);
//                 Console.WriteLine("Книга удалена");
//             }
//             else
//             {
//                 Console.WriteLine("Книга не найдена");
//             }
//             ShowBooks();
//         }
//         static void EditBook()
//         {
//             Console.Write("Введите книгу для изменения: ");
//             string title = Console.ReadLine();
//             var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
//             if (book != null)
//             {
//                 Console.Write("Новое название: ");
//                 string newTitle = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newTitle)) book.Title = newTitle;
//
//                 Console.Write("Новый автор: ");
//                 string newAuthor = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newAuthor)) book.Author = newAuthor;
//
//                 Console.Write("Новый жанр: ");
//                 string newGenre = Console.ReadLine();
//                 if (!string.IsNullOrWhiteSpace(newGenre)) book.Genre = newGenre;
//
//                 Console.Write("Новый год: ");
//                 string newYear = Console.ReadLine();
//                 if (int.TryParse(newYear, out int year)) book.Year = year;
//
//                 Console.WriteLine("Информация о книге обновлена");
//             }
//             else
//             {
//                 Console.WriteLine("Книга не найдена");
//             }
//             ShowBooks();
//         }
//         static void SearchBooks()
//         {
//             Console.Write("Введите параметр поиска: ");
//             string param = Console.ReadLine();
//             var results = books.Where(b => 
//                 b.Title.Contains(param, StringComparison.OrdinalIgnoreCase) ||
//                 b.Author.Contains(param, StringComparison.OrdinalIgnoreCase) ||
//                 b.Genre.Contains(param, StringComparison.OrdinalIgnoreCase) ||
//                 b.Year.ToString().Contains(param)).ToList();
//             if (results.Any())
//             {
//                 Console.WriteLine("Найденные книги:");
//                 foreach (var book in results)
//                 {
//                     Console.WriteLine(book);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Книги не найдены");
//             }
//         }
//         static void AddBookToStart()
//         {
//             Book book = CreateBook();
//             books.AddFirst(book);
//             Console.WriteLine("Книга добавлена в начало списка");
//             ShowBooks();
//         }
//         static void AddBookToEnd()
//         {
//             Book book = CreateBook();
//             books.AddLast(book);
//             Console.WriteLine("Книга добавлена в конец списка");
//             ShowBooks();
//         }
//         static void AddBookToPosition()
//         {
//             Console.Write("Введите позицию для вставки: ");
//             if (int.TryParse(Console.ReadLine(), out int position) && position > 0 && position <= books.Count + 1)
//             {
//                 Book book = CreateBook();
//                 var node = books.First;
//                 for (int i = 1; i < position - 1; i++)
//                 {
//                     node = node.Next;
//                 }
//                 books.AddBefore(node?.Next, book);
//                 Console.WriteLine($"Книга добавлена на позицию {position}.");
//             }
//             else
//             {
//                 Console.WriteLine("Неправильная позиция");
//             }
//             ShowBooks();
//         }
//         static void RemoveBookFromStart()
//         {
//             if (books.Any())
//             {
//                 books.RemoveFirst();
//                 Console.WriteLine("Книга из начала списка удалена");
//             }
//             else
//             {
//                 Console.WriteLine("Список пуст");
//             }
//             ShowBooks();
//         }
//         static void RemoveBookFromEnd()
//         {
//             if (books.Any())
//             {
//                 books.RemoveLast();
//                 Console.WriteLine("Книга из конца списка удалена");
//             }
//             else
//             {
//                 Console.WriteLine("Список пуст");
//             }
//             ShowBooks();
//         }
//         static void RemoveBookFromPosition()
//         {
//             Console.Write("Введите позицию: ");
//             if (int.TryParse(Console.ReadLine(), out int position) && position > 0 && position <= books.Count)
//             {
//                 var node = books.First;
//                 for (int i = 1; i < position; i++)
//                 {
//                     node = node.Next;
//                 }
//                 books.Remove(node);
//                 Console.WriteLine($"Книга на позиции {position} удалена");
//             }
//             else
//             {
//                 Console.WriteLine("Некорректная позиция");
//             }
//             ShowBooks();
//         }
//         static void ShowBooks()
//         {
//             if (books.Any())
//             {
//                 Console.WriteLine("Список книг:");
//                 foreach (var book in books)
//                 {
//                     Console.WriteLine(book);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Список книг пуст");
//             }
//         }
//         static Book CreateBook()
//         {
//             Book book = new Book();
//             Console.Write("Введите название: ");
//             book.Title = Console.ReadLine();
//             Console.Write("Введите автора: ");
//             book.Author = Console.ReadLine();
//             Console.Write("Введите жанр: ");
//             book.Genre = Console.ReadLine();
//             Console.Write("Введите год: ");
//             book.Year = int.Parse(Console.ReadLine());
//             return book;
//         }
//     }
// }
