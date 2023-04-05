using System;
namespace Properties
{
    public class Box
    {
        private int length;
        private int height;


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }
   

        public int Width { get; set; }

  

        public void SetLength(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Length must be greater than 0.");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = -value;
                else
                    height = value;
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public int FrontSurface
        {
            get { return length * height; }
        }

       

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length}, height is {height}, and width is {Width}, so the volume is {Volume}.");
        }
    }
}
