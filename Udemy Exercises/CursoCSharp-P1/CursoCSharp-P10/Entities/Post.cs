using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_P10.Entities
{
    class Post
    {
        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }

        public List<Comment> Comments;

        public Post() { }

        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
            Comments = new List<Comment>();
        }

        public void AddLike()
        {
            Likes++;
        }

        public void ReduceLikes()
        {
            Likes--;
        }

        public void AddComment(string comment)
        {
            Comments.Add(new Comment { Text = comment });
        }

        public void RemoveComment(string comment)
        {
            Comments.Remove(new Comment { Text = comment });
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Date.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Title);
            sb.AppendLine(Content);
            sb.Append(Likes);
            sb.AppendLine(" Likes.");
            sb.AppendLine("Comments:");

            for (int i = 0; i < Comments.Count; i++)
            {
                sb.Append(i + 1);
                sb.Append(". ");
                sb.AppendLine(Comments[i].Text);
            }

            return sb.ToString();
        }
    }
}
