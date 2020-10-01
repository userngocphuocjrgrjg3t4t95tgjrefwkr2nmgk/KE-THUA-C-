namespace He_cac_doi_tuong_hinh_hoc
{
    internal class Rectangle :Shape
    {
       public double height;
        public double width;
        public override double Area()
        {
            return width * height;
        }
        public double getH()
        {
            return height;
        }
        public double getW()
        {
            return width;
        }
        public override double Perimeter()
        {
            return (width + height) * 2;
        }
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public Rectangle()
        {
        }
        public void setHW(double height, double width)
        {
        }
    }
}