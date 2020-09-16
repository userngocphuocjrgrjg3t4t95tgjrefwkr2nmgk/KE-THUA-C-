namespace point
{
    public class Point3d: Point2d
    {
            public int z {set;get;}

            public virtual string ToString3d(){
                return "(" + this.x +"," +this.y +","+ this.z +")"; 
            }
        }
    }
