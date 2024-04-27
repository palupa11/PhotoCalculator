namespace Q3_Photo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Photo familyPhoto= new Photo();
            familyPhoto.Width = 10;
            familyPhoto.Height = 8;
        }
    }
    
    class Photo
    {
        protected double width;
        protected double height;
        protected double price;

        public double Width
        {
            get { return width; }
            set { width = value; }

        }
        public double Height
        {
            get { return height; } 
            set { height = value; }
        }

        public double Price
        {
            get { return price; }
        }

        protected void SetPrice()
        {
            if ((Width == 8 && Height == 10) || (Width == 10 && Height == 8))
            {
                price = eightByTenPrice;
            }
            else if ((Width == 10 && Height == 12) || (Width == 22 && Height == 10))
            {
                price = tenByTwelvePrice;

            }
            else
            {
                price = customPrice;
            }

        }
        public overrride string ToString()
        {
            return GetType().Name; +", Price: " + Price.ToString("C2") + ", Width:" + Width + ", Height: " + Height;
        }


    }
}