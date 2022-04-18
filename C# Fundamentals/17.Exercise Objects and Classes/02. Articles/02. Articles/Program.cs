using System;

namespace _02._Articles
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

        public void Edit(string newContent) => Content = newContent;

        public void ChangeAuthor(string newAuthor) => Author = newAuthor;

        public void Rename(string newTitle) => Title = newTitle;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(':');

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1].TrimStart(' '));
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1].TrimStart(' '));
                        break;
                    case "Rename":
                        article.Rename(command[1].TrimStart(' '));
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
