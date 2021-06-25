using System;

namespace Classes_Objects
{
    class Program
    {
        String Colour = "Red";

        String Colour1 = "Orange";
        static void Main(string[] args)
        {
        Program obj = new Program();
        Console.WriteLine(obj.Colour);
        
       Program obj1= new Program();   //This type of declaration throws error because multiple
        Console.WriteLine(obj1.Colour);   //Calling multiple variables using singlke Object
        Console.WriteLine(obj1.Colour1);
        
        }
    }
}
