using System;
using System.Globalization;
using System.Linq;
using System.Text;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace BookShop
{
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            Console.WriteLine(RemoveBooks(db));
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(x => x.Copies < 4200)
                .ToList();

            context.Books.RemoveRange(books);

            context.SaveChanges();

            return books.Count;
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(x => x.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categoryBooks = context.Categories
                .Select(category => new
                {
                    CatName = category.Name,
                    Books = category.CategoryBooks.Select(x => new
                        {
                            x.Book.Title,
                            x.Book.ReleaseDate.Value
                        })
                        .OrderByDescending(x => x.Value)
                        .Take(3)
                        .ToList()

                })
                .OrderBy(x => x.CatName)
                .ToArray();

            var sb = new StringBuilder();

            foreach (var category in categoryBooks)
            {
                sb.AppendLine($"--{category.CatName}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.Value.Year})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(category => new
                {
                    category.Name,
                    Profit = category.CategoryBooks
                        .Sum(x => x.Book.Price * x.Book.Copies)
                })
                .OrderByDescending(x => x.Profit)
                .ThenBy(x => x.Name)
                .ToArray();

            var result = string.Join(Environment.NewLine, categories
                .Select(x => $"{x.Name} ${x.Profit:f2}"));

            return result;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var author = context.Authors
                .Select(author => new
                {
                    author.FirstName,
                    author.LastName,
                    TotalCopies = author.Books.Sum(book => book.Copies)
                })
                .OrderByDescending(x => x.TotalCopies)
                .ToArray();

            var result = string.Join(Environment.NewLine, author
                .Select(x => $"{x.FirstName} {x.LastName} - {x.TotalCopies}"));

            return result;
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(book => EF.Functions.Like(book.Author.LastName, $"{input}%"))
                .Select(book => new
                {
                    book.Title,
                    AuthorName = book.Author.FirstName + " " + book.Author.LastName,
                    book.BookId
                })
                .OrderBy(x => x.BookId)
                .ToArray();

            var result = string.Join(Environment.NewLine, books
                .Select(x => $"{x.Title} ({x.AuthorName})"));

            return result;
        }

        //public static string GetBookTitlesContaining(BookShopContext context, string input)
        //{

        //}

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(author => author.FirstName.EndsWith(input))
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName
                })
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToArray();

            var result = string.Join(Environment.NewLine, authors.Select(b =>
                $"{b.FirstName} {b.LastName}"));

            return result;
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var targetDate = DateTime.ParseExact(date, "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(book => book.ReleaseDate.Value < targetDate)
                .Select(book => new
                {
                    book.Title,
                    book.EditionType,
                    book.Price,
                    book.ReleaseDate.Value
                })
                .OrderByDescending(books => books.Value)
                .ToArray();

            var result = string.Join(Environment.NewLine, books.Select(b =>
                $"{b.Title} - {b.EditionType} - ${b.Price:f2}"));

            return result;
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();

            //var books = context.Books
            //    .Include(x => x.BookCategories)
            //    .ThenInclude(x => x.Category)
            //    .Where(book => book.BookCategories
            //        .Any(x => categories.Contains(x.Category.Name.ToLower())))
            //    .Select(books => books.Title)
            //    .OrderBy(title => title)
            //    .ToArray();

            var allBooks = context.BooksCategories
                .Where(x => categories.Contains(x.Category.Name.ToLower()))
                .Select(book => book.Book.Title)
                .OrderBy(x => x)
                .ToArray();

            var result = string.Join(Environment.NewLine, allBooks);

            return result;
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var book = context.Books
                .Where(book => book.ReleaseDate.Value.Year != year)
                .Select(book => new
                {
                    book.Title,
                    book.BookId
                })
                .OrderBy(book => book.BookId)
                .ToArray();

            var result = string.Join(Environment.NewLine, book
                .Select(x => x.Title));

            return result;
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(x => x.Price > 40)
                .Select(x => new
                {
                    x.Title,
                    x.Price
                })
                .OrderByDescending(x => x.Price)
                .ToArray();

            var result = string.Join(Environment.NewLine,
                books.Select(x => $"{x.Title} - ${x.Price:F2}"));

            return result;
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var books = context.Books
                .Where(books => books.AgeRestriction == ageRestriction)
                .Select(books => books.Title)
                .OrderBy(title => title)
                .ToArray();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(books => books.EditionType == EditionType.Gold &&
                                books.Copies < 5000)
                .Select(book => new
                {
                    book.BookId,
                    book.Title,
                })
                .OrderBy(x => x.BookId)
                .ToArray();

            var result = string.Join(Environment.NewLine, books.Select(x =>
                x.Title));

            return result;
        }
    }
}
