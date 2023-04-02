namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("How to code", "Keaton Davis", 1500);
            video1.Comments.Add(new Comment("Bob", "Thanks for the help, really helped me out on a final"));
            video1.Comments.Add(new Comment("Joe", "I didnt like the video as much"));
            video1.Comments.Add(new Comment("Gale", "Thank you"));
            videos.Add(video1);

            Video video2 = new Video("Call of Duty Zombies tut", "MrTLexify", 5560);
            video2.Comments.Add(new Comment("KDD299Hjexxx", "I finished this in less than 50 minutes the EE!"));
            video2.Comments.Add(new Comment("Jo33843", "Always funny videos"));
            videos.Add(video2);

            Video video3 = new Video("LDS Conference Talks", "President Nelson", 20000);
            video3.Comments.Add(new Comment("God", "Awesome sauce"));
            videos.Add(video3);

            foreach (Video v in videos)
            {
                Console.WriteLine("Title: " + v.Title);
                Console.WriteLine("Author: " + v.Author);
                Console.WriteLine("Length: " + v.Length + " seconds");
                Console.WriteLine("Number of comments: " + v.GetNumComments());
                Console.WriteLine("Comments:");

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("- " + c.Name + ": " + c.Text);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}