using System;
using System.Security.Cryptography.X509Certificates;

namespace StackOverFlow
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var post = new Post();
            
            void upvote()
            {
                post.Upvote += 1;
            }
             void downvote()
            {
                post.Downvote += 1;
            }


            
            while (true)
            {
                Console.WriteLine("1)CreatePost\n2)ViewPost\n3)Upvote\n4)Downvote");



                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1: post.CreatePost();
                        break;
                    case 2: post.ViewPost(); 
                        break;
                    case 3: upvote();
                        break;
                    case 4: downvote();
                        break;
                
                    default: Console.WriteLine("Wrong Choice");
                        break;

                    
                
                }

          
               

            }
        }
    }
}
