using System.Collections.Generic;

namespace YoutubeVideos
{
    public class Video
    {
        private string title;
        private string author;
        private int lengthInSeconds;
        private List<Comment> comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            this.title = title;
            this.author = author;
            this.lengthInSeconds = lengthInSeconds;
            this.comments = new List<Comment>();
        }

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        public int LengthInSeconds
        {
            get { return lengthInSeconds; }
        }

        public void AddComment(string commenterName, string commentText)
        {
            Comment comment = new Comment(commenterName, commentText);
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}
