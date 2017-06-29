using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Mike";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(lengthOfName);
            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers.";
            //Console.WriteLine(myFaveQuote);

            //String escapeString = "I want a tab after this line \t  I want a new line without WriteLine \n\nHi";
            //string escapeString2 = "I want to show a backsplash here \\  Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if(userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User two is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}
            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Wendy.";
            //string fullSentence = startOfSentence + endOfSentence;
            //Console.WriteLine(fullSentence);

            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);

            //Console.WriteLine("This is a tab \t\n This is a backslash \\  \nThis is a bell sound \a.");
            //Console.WriteLine("Please enter your first name.");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Enter your last name.");
            //string lastName = Console.ReadLine();

            //int lengthOfFirstName = firstName.Length;
            //int lengthOfLastName = lastName.Length;

            //if(lengthOfFirstName > lengthOfLastName)
            //{
            //    Console.WriteLine("First is longer.");
            //}
            //else if(lengthOfFirstName == lengthOfLastName)
            //{
            //    Console.WriteLine("Samsis!");
            //}
            //else
            //{
            //    Console.WriteLine("Last name must be longer.");
            //}
            //Console.WriteLine("Please enter your first name.");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter a different first name.");
            //string secondName = Console.ReadLine();


            //if (firstName == secondName) // or you can use (firstName.Equals(secondName))
            //{
            //    Console.WriteLine("The names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}
            Console.WriteLine("Please enter 1 number.");
            int holeNumber = int.Parse(Console.ReadLine());
                        
            if (holeNumber < 0 || holeNumber > 9)
            {
                Console.WriteLine("Please enter a number between 1 and 9.");
            }
            else if(holeNumber == 0 || holeNumber == 1 || holeNumber == 6 || holeNumber == 9)
            {
                Console.WriteLine("1 hole");
            }
            else if (holeNumber == 8)
            {
                Console.WriteLine("2 holes");
            }

            else
            {
                Console.WriteLine("No holes");
            }
        }
    }
}

