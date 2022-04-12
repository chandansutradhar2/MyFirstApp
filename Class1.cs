using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
     class Class1
    {
        public string UserName = "chandan";
        public void DoSomeThing() {
            Console.WriteLine("Do Some Work here");
        }

        public static void AccessWithoutObject()
        {

        }

        public void Add()
        {
            //Console.WriteLine("Enter First Number");
            //int n1= Convert.ToInt16( Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //int n2 = Convert.ToInt16(Console.ReadLine().Trim());
            //Console.WriteLine($"The Sum of {n1} and {n2} is ={ n1 + n2}");

            bool isAdmin=Convert.ToBoolean("false");

            //isAdmin==true? Console.WriteLine("user is admin"):Console.WriteLine("user is not admin");


            //if (isAdmin == true)
            //{
            //    Console.WriteLine("user is admin");
            //}
            //else {
            //    Console.WriteLine("user is not admin");
            //}

         
            
            //Console.WriteLine(someData.Contains("france"));
           // Console.WriteLine(someData.Trim());
            


        }
    }
}
