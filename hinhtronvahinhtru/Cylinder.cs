using System.Collections.Generic;
namespace hinhtronvahinhtru

{
    public class Cylinder:Circle
    {

        private double height;

        public Cylinder()
        {
        }

        public Cylinder(double height, double radius, string color){
            this.height=height;
        }
        public void setHeight(double _height){
            height=_height;
        }

        public double getHeight(){
            return height;
        }

        public  double thetich(){
            return area * height;
        }

        public override string ToString(){
            return "Height= " + height + " The tich la: "+thetich();
        }
    }
}