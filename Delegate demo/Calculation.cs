using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_demo
{
    public delegate int MyDelegate(int x, int y);
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    
        public delegate void Delegate1(int id, string name, double salary);
        public class Test
        { 

                public void AcceptDetails(int id, string name, double salry)
                {
                     Console.WriteLine($"{id},{name},{salry}");
                }
        }
    
}
    

    


   
