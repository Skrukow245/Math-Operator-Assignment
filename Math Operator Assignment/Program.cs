using System;


namespace Math_Operator_Assignment
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string Hourly = Console.ReadLine();               //getting user input
            int hours = Int32.Parse(Hourly);                //turning user input into an int
            Console.WriteLine("Hours worked per week?");
            string Weekly = Console.ReadLine();
            int weeks = Int32.Parse(Weekly);
            string annual = (hours * weeks * 52).ToString();   //multiplying both int to get annual



            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string Hourly2 = Console.ReadLine();
            int hours2 = Int32.Parse(Hourly2);
            Console.WriteLine("Hours worked per week?");
            string Weekly2 = Console.ReadLine();
            int weeks2 = Int32.Parse(Weekly2);
            string annual2 = (hours2 * weeks2 * 52).ToString();





            Console.WriteLine("Annual salary ofPerson 1:");
            Console.WriteLine(annual);
            Console.WriteLine("Annual salary ofPerson 2:");
            Console.WriteLine(annual2);
            int x = Int32.Parse(annual);     //turning the annual of each into into to be compared 
            int y = Int32.Parse(annual2);



            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueorFalse = x > y;      //checking to see if annual is higher than annual2
            Console.Write(trueorFalse.ToString());
            Console.ReadLine();                
        }
    }
}
