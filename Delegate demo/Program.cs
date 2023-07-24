using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Delegate_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            // calculation.Add =added method referance

            MyDelegate myDelegate = new MyDelegate(calculation.Add);// added the ref of Add();

            //+= add ref in invogation list
            myDelegate += new MyDelegate(calculation.Sub);//adding another ref of Sub();


            //-= remove method from invogation list
            // my Delegate -= new MyDelegate(calculation.Sub);
            
            Delegate[]list =myDelegate.GetInvocationList();
            foreach  (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(45,22));//DynamicInvoke for multidelegate;


            }

            Test test = new Test();
            Delegate1 d = new Delegate1(test.AcceptDetails);
            d.Invoke(1, "pankaj", 10000);

        }
    }
}
        
    
   
