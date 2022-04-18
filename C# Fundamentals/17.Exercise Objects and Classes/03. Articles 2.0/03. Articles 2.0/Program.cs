using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Article
    {
        private string Title_;
        private string Content_;
        private string Author_;

        public Article(string title, string content, string author)
        {
            this.Title_ = title;
            this.Content_ = content;
            this.Author_ = author;
        }

        public string Title { get => Title_; set => Title_ = value; }

        public string Content { get => Content_; set => Content_ = value; }

        public string Author { get => Author_; set => Author_ = value; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(", ");
                string title = info[0];
                string content = info[1];
                string author = info[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string line = Console.ReadLine();
            switch (line)
            {
                case "title":
                    articles.Sort((article1, article2) =>
                        article1.Title.CompareTo(article2.Title));
                    break;
                case "content":
                    articles.Sort((article1, article2) =>
                    article1.Content.CompareTo(article2.Content));
                    break;
                case "author":
                    articles.Sort((article1, artilce2) =>
                    article1.Author.CompareTo(artilce2.Author));
                    break;
            }

            articles.ForEach(Console.WriteLine);
        }
    }
}
