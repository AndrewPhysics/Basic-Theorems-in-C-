using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Tetelek
    {
       
       
        //függvények
        public void csere(int x, int y) 
        {
            Console.WriteLine("x: {0}", x, "y: {0},",y);
            int tmp = x;
            x = y;
            y = tmp;
            Console.WriteLine("x: {0}", x, "y: {0},", y);
        } 
        public int osszegzes(int[] aa, int m)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum = sum + aa[i];
            }
            return sum;
        }
        public bool property(int x)
        {
            if(x==4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void eldontes(int[] aa, int m)
        {
            int i;
            for (i = 0; i < m && !property(aa[i]); i++)
            {}
            if (i<m)
            {
                Console.WriteLine("Megvan!");
            }
            else
            {
                Console.WriteLine("Nincs meg!");
            }
        } 
    }
    class TetelekProgram
    {
        static void Main(string[] args)
        {
            Tetelek reka = new Tetelek();
            int x = 10;
            int y = 20;

            int[] aa = { 1, 2, 3, 4, 5 };

            reka.csere(x,y);
            Console.WriteLine("sum: {0}", reka.osszegzes(aa, 5) );
            reka.eldontes(aa,5);
           
            Console.ReadKey();
        }
    }
}

