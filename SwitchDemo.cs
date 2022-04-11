using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class SwitchDemo
    {

        //program objective : 35 - fail, 50 - pass, 65 - first class - 75 - distinction

        public void PrintResult(int score) {

            Console.WriteLine("Print Result invoked");
            if (score > 0 && score < 35) 
            {
                Console.WriteLine("Fail");
            }
            else if(score >=35 && score < 65)
            {
                Console.WriteLine("Pass");
            }
            else if(score >=65 && score < 75)
            {
                Console.WriteLine("First");
            }
            else if(score >=75 && score <= 100)
            {
                Console.WriteLine("Distinction");
            }
            else
            {
                Console.WriteLine("unale to determine score");
            }
            //switch (score) 
            //{
            //    case  : 
            //        Console.WriteLine("Fail");
            //        break;
            //    case 50: Console.WriteLine("Pass");
            //        break;
            //    case 65: Console.WriteLine("First");
            //        break;
            //    case 75: Console.WriteLine("Distinction");
            //        break;
            //    default: Console.WriteLine("Unable to determine score");
            //        break;
                    
            //}
        
        }

        public void PrintGreeting(string wish)
        {
            //switch (wish)
            //{
            //    case "morning":
            //        Console.WriteLine("Good Morning");
            //        break;
            //    case "afternoon":
            //        Console.WriteLine("Good Afternoon");
            //        break;
            //    case "evening":
            //        Console.WriteLine("Good Evening");
            //        break;
            //    case "night":
            //        Console.WriteLine("Good Night");
            //        break;
            //    default:
            //        Console.WriteLine("unable to determine wish format");
            //        break;
            //}

            if (wish == "morning")
            {
                Console.WriteLine("Good Morning");
            }
            else if (wish == "afternoon")
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (wish == "evening")
            {
                Console.WriteLine("Good Evening");
            }
            else if (wish == "night")
            {
                Console.WriteLine("Good Night");
            }
            else
            {
                Console.WriteLine("unable to wish");
            }
        }
    }

    


}
