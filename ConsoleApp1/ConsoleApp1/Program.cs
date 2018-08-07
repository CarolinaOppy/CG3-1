using System;

namespace month
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing the purpose of this program and asking to get my variable//
            Console.WriteLine("This program is going to change the number of your birth month into the word of your birth month.");
            Console.WriteLine("Please enter the number of the month you were born.");
            //establishing answer as variable//
            var month = Console.ReadLine();

            //creating the string to read input//
            string message = "";
            
            //the if, else if, else statements//
            if (month == "1")
            {
                message = "January";
            }
            else if (month == "2")
            {
                message = "February";
            }
            else if (month == "3")
            {
                message = "March";
            }
            else if (month == "4")
            {
                message = "April";
            }
            else if (month == "5")
            {
                message = "May";
            }
            else if (month == "6")
            {
                message = "June";
            }
            else if (month == "7")
            {
                message = "July";
            }
            else if (month == "8")
            {
                message = "August";
            }
            else if (month == "9")
            {
                message = "September";
            }
            else if (month == "10")
            {
                message = "October";
            }
            else if (month == "11")
            {
                message = "November";
            }
            else if (month == "12")
            {
                message = "December";                
            }
            else
            {
                message = "Sorry I don't understand.";
            }
            // finishing message//
            Console.WriteLine(message);
            Console.ReadLine();
        
        }
    }
}
