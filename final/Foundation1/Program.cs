using System;
using System.Collections.Generic;

namespace YoutubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create 3-4 videos with comments
            Video video1 = new Video("This Cooler Might Kill Your CPU", "Linus Tech Tips", 1130);
            video1.AddComment("Ali Yazandi", "Alex and Linus are such a good combination, one of them suggests a crazy idea and the other one happily accepts it.");
            video1.AddComment("Fabian Castellano", "12:40 the editor of this video deserves a raise, that moment was perfect");
            video1.AddComment("Garrett Reyman", "Linus and Alex both define success as 'its not broken' and I really appreciate that");
            videos.Add(video1);

            Video video2 = new Video("Spring Chill Mix", "Alex Aero", 2194);
            video2.AddComment("S0MIX", "This mix is just purely awesome. Love your stuff, Alex!");
            video2.AddComment("Tayla Thibaudin", "These songs harmonise so soothingly - this mix is hauntingly beautiful");
            video2.AddComment("zonerdip", "Ive had this on repeat for a week and I'm still not tired of it. Thank you for this <3");
            videos.Add(video2);

            Video video3 = new Video("Making The Ultimate Bento Box At Home", "Joshua Weissman", 573);
            video3.AddComment("Velma", "Can we get a “Let Me Cook” series where Joshie chooses something to make but is given random ingredients");
            video3.AddComment("Nenad Popov", "I watch a lot of cooking videos but nobody does it like Joshua, I get instantly hungry even when I'm full lol.");
            videos.Add(video3);

            Video video4 = new Video("Polar Bear Dance - relaxing study music", "indiebucket", 205);
            video4.AddComment("Luke Egan", "I love this!!!!");
            videos.Add(video4);

            // Display information for each video
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"Comment by {comment.CommenterName}: {comment.CommentText}");
                }
                Console.WriteLine();
            }
        }
    }
}
