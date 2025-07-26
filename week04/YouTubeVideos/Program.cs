using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video miVideo = new Video("Trusting Our Father", "General Conference of The of Jesus Christ", 120);

        Comment comment1 = new Comment("@masham7197", "I have social anxiety, and because of that could not attend church for a long time. I see myself in that woman's story. The reasons for leaving may be different, but the coming back is the same. Trusting Him is the same. He has helped me. It is not always easy, but it's where I want to be");
        Comment comment2 = new Comment("@kahealani8502", "Loveee this");

        miVideo.AddComment(comment1);
        miVideo.AddComment(comment2);

        Console.WriteLine($"Title: {miVideo.GetTitle()} by {miVideo.GetAuthor()}");
        Console.WriteLine($"Length: {miVideo.GetLength()} seconds");

        miVideo.DisplayComments();

    }


}