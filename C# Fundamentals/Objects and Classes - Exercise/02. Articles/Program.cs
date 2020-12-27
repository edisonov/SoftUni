using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Създайте статия за клас със следните свойства:
            • Заглавие - низ
            • Съдържание - низ
            • Автор - низ
            Класът трябва да има конструктор и следните методи:
             • Редактиране (ново съдържание) - променете старото съдържание с новото
             • ChangeAuthor (нов автор) - промяна на автора
             • Преименуване (ново заглавие) - променете заглавието на статията
             • Замяна на метода ToString - отпечатайте статията в следния формат:„{title} - {content}: {autor}“
            Напишете програма, която чете статия в следния формат „{title}, {content}, {author}“.
            На следващия ред ще получите число n, представляващо броя на командите, които ще последват след него.
            На следващите n реда ще получавате следните команди:
            „Редактиране: {ново съдържание}“; "ChangeAuthor: {нов автор}"; „Преименуване: {ново заглавие}“.
            В края отпечатайте крайното състояние на статията.
             */
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public void Edit(string content)
            {
                this.Content = content;
            }

            public void ChangeAuthor(string author)
            {
                this.Author = author;
            }

            public void Rename(string title)
            {
                this.Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
