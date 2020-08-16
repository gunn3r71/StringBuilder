using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_resolvido_122_stringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemovoComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            _ = sb.AppendLine(Title);//adiciona um texto ao final do string builder e o 
            _ = sb.AppendLine(Likes + " Likes - " + Moment);//appendLine faz o mesmo con uma quebra de linha  
            _ = sb.Append(Content);
            _ = sb.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                _ = sb.AppendLine(comment.Text);
            }
            return sb.ToString();
        }
    }
}
