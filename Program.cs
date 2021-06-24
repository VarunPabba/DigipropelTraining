using System;

class Program
{
       public string model;
       public string color;
       public int year;

       public Program(string modelName, string modelColor, int modelYear)
           {
               model = modelName;
               color = modelColor;
               year = modelYear;
           }

       static void Main(string[] args)
           {
               Program Ford = new Program("Mustang", "Red", 1969);
               Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
           }
}
