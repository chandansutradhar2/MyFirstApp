using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class LoopDemo
    {
        public void WhileLoopDemo() 
        {
            int num = 0;

            while (num <2000) {
                Console.WriteLine($"{num} is less than 2000");
                if(num == 1000)
                {
                    break;
                }
                num++;
                //num=num+1; //important 
            }
            
        }

        public void LocateStore(string cityName)
        {
            string[] stores = { "mumbai", "delhi", "pune", "nashik", "dahanu", "chennai", "agra" };
            int length = stores.Length;
            int cnt = 0;

            while(cnt<length)
            {
                if(stores[cnt] == cityName)
                {
                    Console.WriteLine("Our Store is present in " + cityName);
                    break;
                }

                cnt++;
            }

        }

        public void DoWhileLoopDemo()
        {

            int i = 0;
            do
            { 
            Console.WriteLine(i);
                i++;
            }while(i < 10);

        }

        public void TrackSession()
        {
            string result;
            do
            {
                Console.WriteLine("you still want to keep session open ? (Y / N)");
                result = Console.ReadLine();

                Console.WriteLine("you are logged in");

            } while (result.ToLower() == "y");

        }

    }
}
