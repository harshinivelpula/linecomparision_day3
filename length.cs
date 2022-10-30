using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparion
{
    internal class length
    {
        public int X1;
        public int X2;
        public int Y1;
        public int Y2;
        public int S1;
        public int S2;
        public int R1;
        public int R2;
        public void Length()
        {
            Console.WriteLine("Enter x, y co ordinates of the line 1 :");
            Console.WriteLine("Enter value X_One");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X_Two");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y_One");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y_Two");
            Y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter x, y co ordinates of the line 2 :");
            Console.WriteLine("Enter value of S_One");
            S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S_Two");
            S2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_One");
            R1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R_Two");
            R2 = Convert.ToInt32(Console.ReadLine());

            double Length_XY = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Line 1 is:: " + Length_XY);

            double Length_SR = Math.Sqrt(Math.Pow((S2 - S1), 2) + Math.Pow((R2 - R1), 2));
            Console.WriteLine("Length of Line 2 is: " + Length_SR);

        }

    }
}
