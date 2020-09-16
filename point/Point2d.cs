namespace point
{
    public class Point2d
    {
            public float x {get;set;}
            public float y {get;set;}


           public virtual string ToString2d(){
               return "(" + this.x +"," +this.y +")"; 
            }
        
    }
}