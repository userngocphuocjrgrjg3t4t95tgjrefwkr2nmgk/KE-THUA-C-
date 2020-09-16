using System;

namespace hinhtronvahinhtru
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.setColor("red");
            c.setRadius(10);
            Console.WriteLine(c.ToString()); 
            Cylinder cy = new Cylinder();  
            cy.setColor("blue");
            cy.setRadius(5);
            cy.setHeight(15);
            cy.Area();
            Console.WriteLine(cy.ToString());

    }
}
}
