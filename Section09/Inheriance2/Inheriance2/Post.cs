using System;


namespace Inheriance2
{
    public class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }


        public Post()
        {
            ID = 0;
            Title = "First Post";
            IsPublic = true;
            SendByUserName = "Tikaani Aurora";
        }

        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }


        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName}");
        }

    }
}
