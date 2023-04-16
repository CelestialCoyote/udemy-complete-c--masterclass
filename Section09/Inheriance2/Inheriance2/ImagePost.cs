using System;


namespace Inheriance2
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUserName}");
        }
    }
}
