using System;

namespace Variables
{
    class Variables
    {
         static string name = "Akhilesh";  //Static kind of String type Variable declaration
         String FullName = "PabbaVarun";   //Non-Static kind of String type Variable declartion
        static void Main(string[] args)
        {
            Variables obj = new Variables();    //Creating Object for calling Non-Static variable
            Console.WriteLine(obj.FullName);    //calling Variabkle to print variable

            string myname = "Varun Gupta";       //declaring local String typeVariable
            Console.WriteLine("My name is "+ myname);          //printing local String type variable and concatination happened here

            Console.WriteLine(name);            //printing global static variable

            int myNum = 15;                     //declaring local int type Variable
            Console.WriteLine(myNum);           //printing local int type variable 

            int Number;                         //Intializing local int type Variable
            Number = 15;                        //Declaring local int type Variable
            Console.WriteLine(Number);

            int ChangeNumber = 15;              //Intializing local int type Variable
            ChangeNumber = 20;                  //Changing Number to other Number here is now 20
            Console.WriteLine(ChangeNumber);    //printing the new number stored in old memory Location

            const int Number1 = 15;             //Declaring Local Variable  type Constant int
            // Number1 = 20;                    // Throws Error because constant meant to be fixed
            Console.WriteLine(Number1);         //Printing Local Variable  type Constant int 

            double DoubleNumber= 5.99D;         //Declaring  Local Double type Variable
            Console.WriteLine(DoubleNumber);    //Printing  Local int type Variable

            char Letter = 'D';                  //Declaring  Local type Character Variable
            Console.WriteLine(Letter);          //Printing  Local Character type Variable
            
            bool Boolean = true;                //Declaring Boolean  type Variable
            Console.WriteLine(Boolean);         //Printing  Local  type Variable

            string String = "Hello";            //Declaring String  type Variable
            Console.WriteLine(String);          //Printing String  type Variable

            string firstName = "Pabba ";              //String Declaration as local Variable
            string lastName = "Varun";                //String Declaration as local Variable
            string fullName = firstName + lastName;   //Concantination using String names
            Console.WriteLine(fullName);              //Printing String  type Variable

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);                 // Printing the value of x + y

            int p = 5, q = 6, r = 50;
            Console.WriteLine(p + q + r);
        }
    }
}
