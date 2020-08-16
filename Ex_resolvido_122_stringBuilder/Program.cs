using Ex_resolvido_122_stringBuilder.Entities;
using System;
using System.Runtime.CompilerServices;

namespace Ex_resolvido_122_stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traviling to New Zealend",
                    "I'm going to visit this wonderfull country!",
                    12
           );
           Post post2 = new Post(
                   DateTime.Parse("28/07/2018 23:14:19"),
                   "Good night guys",
                   "See you tomorrow",
                   5
           );

            post.AddComment(new Comment("Have a nice trip!"));
            post.AddComment(new Comment("Whoa that's awesome!"));
            post2.AddComment(new Comment("Good Night"));
            post2.AddComment(new Comment("May the force be with you"));

            Console.WriteLine(post + "\n" + post2);

        }
    }
}
