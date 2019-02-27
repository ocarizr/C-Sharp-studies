using System;
using System.Collections.Generic;
using CursoCSharp_P10.Entities;

namespace CursoCSharp_P10
{
    class Program
    {
        public static List<Post> Posts = new List<Post>();

        static void Main(string[] args)
        {
            int option = 1;
            while(option!=0)
            {
                Console.WriteLine("What you want to do?");
                Console.WriteLine("1. Post something.");
                Console.WriteLine("2. Like a post");
                Console.WriteLine("3. Dislike a post");
                Console.WriteLine("4. Add a comment");
                Console.WriteLine("5. Remove a comment");
                Console.Write("Command: ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        AddPost();
                        break;
                    case 2:
                        LikeOrDislikePost(1);
                        break;
                    case 3:
                        LikeOrDislikePost(0);
                        break;
                    case 4:
                        AddComment();
                        break;
                    case 5:
                        RemoveComment();
                        break;
                    case 0:
                        Console.WriteLine("Ok, Goodbye!");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Command.");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Posts:");
            for (int i =0; i < Posts.Count; i++)
            {
                Console.WriteLine($"#{i + 1} Post:");
                Console.WriteLine(Posts[i]);
                Console.WriteLine();
            }
        }

        static void AddPost()
        {
            string title;
            string content;

            Console.WriteLine();
            Console.Write("Input the title of the post: ");
            title = Console.ReadLine();
            Console.Write("Input the post content: ");
            content = Console.ReadLine();

            Posts.Add(new Post(DateTime.Now, title, content, 0));
            Console.WriteLine();
        }

        static void LikeOrDislikePost(int option)
        {
            if (Posts.Count == 0)
            {
                Console.WriteLine($"There's no post to {(option == 1 ? "Like" : "Unlike")}.");
                return;
            }

            Post post = SelectPost();

            Console.WriteLine();

            if (option == 1)
            {
                post.AddLike();
                return;
            }

            post.ReduceLikes();
        }

        static void AddComment()
        {
            string comment;
            if (Posts.Count == 0)
            {
                Console.WriteLine($"There's no post.");
                return;
            }

            Post post = SelectPost();

            Console.Write("Type the Comment: ");
            comment = Console.ReadLine();
            post.AddComment(comment);

            Console.WriteLine();
        }

        static void RemoveComment()
        {
            string comment;
            int command;
            if (Posts.Count == 0)
            {
                Console.WriteLine($"There's no post.");
                return;
            }

            Post post = SelectPost();

            Console.WriteLine("Select the comment to remove:");
            for(int i = 0; i < post.Comments.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {post.Comments[i].Text}");
            }
            Console.Write("Command: ");
            command = int.Parse(Console.ReadLine());

            comment = post.Comments[command - 1].Text;

            post.RemoveComment(comment);

            Console.WriteLine();
        }

        private static Post SelectPost()
        {
            Console.WriteLine();
            Console.Write("Type the title of the post: ");
            string title = Console.ReadLine();
            Post post = Posts.Find(p => p.Title == title);
            return post;
        }
    }
}
