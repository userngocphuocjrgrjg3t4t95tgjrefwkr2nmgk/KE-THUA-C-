using System;

namespace He_cac_doi_tuong_hinh_hoc
{
    public abstract class Shape
    {
        public string Color;
        public string Point;
        public abstract double Area();
        public void getColor()
        {
            Console.WriteLine("Color: {0}", Color);
        }
        public void getOrigin()
        {
            Console.WriteLine("Origin: {0}", Point);
        }
        public abstract double Perimeter();
        public void setColor(string col)
        {
            col = Color;
        }
        public void setOrigin(string org)
        {
            org = Point;
        }
        public Shape(string Color, string Point)
        {
            this.Color = Color;
            this.Point = Point;
        }
        public Shape(string Point)
        {
            this.Point = Point;
        }
        public Shape()
        {
        }
    }
}