using System;
using System.Threading;


namespace Inheriance2
{
    public class VideoPost : Post
    {
        protected bool IsPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} - by {this.SendByUserName}");
        }

        public void Play()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Playing");

                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"Video at {currentDuration}");
            }
            else
                Stop();
        }

        public void Stop()
        {
            if (IsPlaying)
            {
                IsPlaying = false;
                Console.WriteLine($"Stopped at {currentDuration}");
                currentDuration = 0;
                timer.Dispose();
            }
        }
    }
}
