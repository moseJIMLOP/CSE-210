using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video Video1 = new Video("Trusting Our Father", "General Conference of The of Jesus Christ", 120);
        Video Video2 = new Video("You're Not Alone in Mortality", "Light of Christ+", 840);
        Video Video3 = new Video("The Power of the Atonement", "LDS General Conference", 300);

        Video1.AddComment(new Comment("@masham7197", "I have social anxiety, and because of that could not attend church for a long time. I see myself in that woman's story. The reasons for leaving may be different, but the coming back is the same. Trusting Him is the same. He has helped me. It is not always easy, but it's where I want to be"));
        Video1.AddComment(new Comment("@kahealani8502", "Loveee this"));
        Video1.AddComment(new Comment("@slymet", "Thank you💛😇"));

        Video2.AddComment(new Comment("@Peugeot2213", "days ago I met you you knew"));
        Video2.AddComment(new Comment("@denisehowell1687", "GOD ❤ LOVES US ALL❤ I LOVE YOU ALL MY BELOVED BROTHERS AND SISTERS ❤❤"));
        Video2.AddComment(new Comment("@Peugeot22", "Never heard a word about grace. Mixing grace with works will never work...."));
        Video2.AddComment(new Comment("@millennialfalkon", "I love this talk! Years after it was first given I still listen to it over and over."));

        Video3.AddComment(new Comment("@craigbrooksby8488", "This apostle of Jesus Christ is absolutely amazing.I love him."));
        Video3.AddComment(new Comment("@angiesantos8261", "Simplicity in truth  a very good message for our days"));
        Video3.AddComment(new Comment("@jasonpierce6997", "God bless you very much"));

        List<Video> videos = new List<Video>() { Video1, Video2, Video3 };
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()} by {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            video.DisplayComments();
            Console.WriteLine("_______________________________");
        }
    }
}