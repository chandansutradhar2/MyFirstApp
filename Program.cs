﻿using System;

namespace MyFirstApp
{
    internal class Program
    {
        int cnt = 10;
        static void Main(string[] args)
        {

            Class1 obj=new Class1();
            obj.Add();

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
