using System;

namespace myFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double SideA;
            //inslzing var
            double SideB;
            //inslzing var
            double sidec;
            //inslzing var
            Console.WriteLine("enter side a ");
            //writing to user  what input  do i want to get
            SideA=  Convert.ToDouble(Console.ReadLine());
            //getting SideA from user input, and converting it to double 
            Console.WriteLine("enter side b");
            //writing to user  what input  do i want to get

            SideB=  Convert.ToDouble(Console.ReadLine());
            //getting SideA from user input, and converting it to double 

            SideA = Math.Pow(SideA, 2);
            //getting the var power 2 
            SideB = Math.Pow(SideB, 2);
            //getting the var power 2
            sidec = Math.Sqrt(SideA + SideB);
            //
            Console.WriteLine(sidec);




        }
    }
}