using System;

class Program
{
    static void Main(string[] args)
    {
{
        List<Video> videos = new List<Video>();

        // First example video
        Video video1 = new Video("The Future of AI", "TechWorld", 480);
        video1.AddComment(new Comment("Alice", "Amazing insights, thanks!"));
        video1.AddComment(new Comment("Bob", "I love this channel."));
        video1.AddComment(new Comment("Charlie", "Great explanation!"));
        videos.Add(video1);

        // Second example video
        Video video2 = new Video("Easy Pasta Recipe", "ChefDaily", 300);
        video2.AddComment(new Comment("Diana", "Tried this today, delicious!"));
        video2.AddComment(new Comment("Eric", "More vegetarian options please."));
        video2.AddComment(new Comment("Fay", "Can you do a gluten-free version?"));
        videos.Add(video2);

        // Third example video
        Video video3 = new Video("How to Build a Gaming PC", "BuildMaster", 720);
        video3.AddComment(new Comment("George", "Saved me hundreds of dollars!"));
        video3.AddComment(new Comment("Hannah", "Clear and informative."));
        video3.AddComment(new Comment("Ian", "I was overwhelmed before this."));
        videos.Add(video3);

        // Display video details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length (seconds): {video._length}");
            Console.WriteLine($"Number of Comments: {video.CommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}    
}