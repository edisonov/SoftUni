using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Променете програмата по такъв начин, че да можете да съхранявате списък със статии.
             Повече няма да се налага да използвате предишните методи (с изключение на метода ToString). 
             На първия ред ще получите броя статии. 
             На следващите редове ще получавате статиите в същия формат като при предишния проблем:
             „{title}, {content}, {author}“. Накрая ще получите низ: „заглавие“, „съдържание“ или „автор“. 
            Трябва да поръчате статиите по азбучен ред, въз основа на дадените критерии.
             */
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] tokesn = Console.ReadLine().Split(", ");
                string title = tokesn[0];
                string content = tokesn[1];
                string author = tokesn[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList(); 
            }
            else if (criteria == "content")
            {
                articles.Sort((c1, c2) => c1.Content.CompareTo(c2.Content));
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
