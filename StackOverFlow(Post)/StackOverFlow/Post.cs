using System;

namespace StackOverFlow
{
    partial class Program
    {
        public class Post
        {
            string title;
            string Discription;
            private int _upvote=0;
            private int _downVote=0;
            DateTime thistime = new DateTime();
           


            public int Upvote
            {
                get
                {
                    return _upvote;
                }
                set
                {
                    _upvote = value;
                }

            }
            public int Downvote
            {
                get
                {
                    return _downVote;
                }
                set
                {
                    _downVote = value;
                }

            }
         
            public void  CreatePost()
            {
                Console.WriteLine("Enter the Title");
                title = Console.ReadLine();
                Console.WriteLine("Enter the discription");
                Discription = Console.ReadLine();
                thistime = DateTime.Now;
              


            }
            public void ViewPost()
            {
                Console.WriteLine("Title-->{0}",title);
                Console.WriteLine("Discription-->{0}",Discription);
                Console.WriteLine("TimeOfCreation-->{0}",thistime);
                Console.WriteLine("Upvotes-->{0} DownVotes-->{1}", Upvote, Downvote);

            }
        




        }
    }
}
