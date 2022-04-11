using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class ForLoopDemo
    {

        public void ForLoop() {
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 10; i >= 0; i--)
            {
               
                if (i == 5)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);                
            }
        }

        public void ShowHigestScore(int []scores)
        {
            int higestScore = 0;
            int length=scores.Length;

            for (int i = 0; i < length; i++)
            {              
                if(scores[i] > higestScore)
                {
                    higestScore = scores[i];
                }
            }
            Console.WriteLine(higestScore);
        }

        public void ForEachLoopDemo(int [] scores)
        {
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
        }

        public void FindAverage(int[] scores)
        {
            int sumOfScore=0;
            foreach (var item in scores)
            {
                sumOfScore = sumOfScore + item;
            }
            Console.WriteLine("Average Score is :" + sumOfScore / scores.Length);

        }
    }
}
