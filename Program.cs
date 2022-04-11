using System;

namespace MyFirstApp
{
    internal class Program
    {
        int cnt = 10;
        static void Main(string[] args)
        {

            ForLoopDemo obj = new ForLoopDemo();
            //obj.ForLoop();
            int[] myScores = { 28, 48, 38, 15, 37, 100, 65, 34, 22, 81, 72, 44, 34, 23, 21, 75, 56, 78, 45, 44, 89, 98, 76, 75, 71, 23, 34, 32, 22 };
            //obj.ShowHigestScore(myScores);
            //obj.ForEachLoopDemo(myScores);
            obj.FindAverage(myScores);
            //LoopDemo obj=new LoopDemo();
            //obj.WhileLoop();
            //obj.LocateStore("pune");
            //obj.DoWhileLoopDemo();
            //obj.TrackSession();
            //SwitchDemo obj2 = new SwitchDemo();
            //Console.WriteLine("Enter Score");
            //int score=Convert.ToInt32 (Console.ReadLine());
            //obj2.PrintResult(score);
            //obj2.PrintGreeting("night");

            //int cnt=10;
            //const double pieValue=3.14;

            //string stringCnt = Convert.ToString(cnt);
            
            //double varDouble = 10.76;
            //char varChar = 'a';
            //string varString = "this is a string variable";
            //bool varBool = false;
            //Console.WriteLine(varBool);
            //Console.WriteLine(varString);
            //Console.WriteLine("Char value="+varChar);
            //cnt = 10;
            ////pieValue = 3.16;
            
            //Console.WriteLine("int cnt="+cnt);
            //Console.WriteLine("double varDouble=" + varDouble);

            

        }

        void SomeMethod() 
        {
       

            cnt = 200;
            cnt = 500;

        }

        void AnotherMethod()
        {
            
            cnt = cnt - 50;
        }

    }
}
