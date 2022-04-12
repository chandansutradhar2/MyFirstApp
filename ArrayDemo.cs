using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class ArrayDemo
    {
//exercise: sort array of string to ascendeing /descending order
//2: filter an array of names
//3: find an element inside an array
//4: adding to array

        public void PrintName()
        {
            string[] names = { "chandan","anshuman","ranjan","sameer"};//multiple name
            //string name;//single name
            Console.WriteLine(names.Length);
            string[]cars=new string[4];
            cars[0] = "tiago";
            cars[1] = "hexa";
            cars[2] = "safari";
            cars[3] = "nexon";
            // will genearte outofBound Exception cars[4] = "indica";
            int [] scores = { 2,4,5,6,8,9,7,2,1,3};
            Console.WriteLine(scores.Length);

            foreach (var item in names)
            {
                Console.WriteLine(item +" sutradhar");
            }

            Console.WriteLine(scores.Min());
            Array.Sort(scores);
            Array.ForEach(scores, x => {
                Console.WriteLine(x);
                Console.WriteLine(x + 10);

            });

            //foreach (var item in scores)
            //{
            //    Console.WriteLine(item);   
            //}
        }
    }
}
