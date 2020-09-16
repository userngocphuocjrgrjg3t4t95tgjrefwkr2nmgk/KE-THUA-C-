using System;

namespace hinhtronvahinhtru
{
    public class Circle
    {   
        private double radius;
        private string color;

        public double area;
        public Circle(){

        }
        public Circle(double _radius, string _color){
            radius = _radius;
            color = _color;
        }

        public void setRadius(double _radius){
            radius=_radius;
        }
        public double getRadius(){
            return radius;
        }

          public void setColor(string _color){
           color = _color;
        }
        public string getColor(){
            return color;
        }

        public double Area(){
            return area= Math.PI*radius*radius;
        }
        public override string ToString(){
            return "Radius: "+ radius+" Color: "+color + " Dien tich: "+ Area();
        }
}
}