
using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)

        {
            //declare global variables

            string fName;
            string lName;
            double age;
            int bMonth;
            string favColor;            
            int numSibs;
            string evenOrOdd;
            int yearsToRetire;
            string vacHome = "";
            string transportation;
            string bankAccount = "";



            //ask the user for input - first name, last name, age, birth month, favorite color, and number of siblings

            Console.WriteLine("Please tell me your first name");
            fName = Console.ReadLine().ToLower();
            //  Console.WriteLine(fName); testing value of fname

            Console.WriteLine("Please tell me your last name");
            lName = Console.ReadLine().ToLower();
            //   Console.WriteLine(lName); testing value of lname

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            //   Console.WriteLine(age); testing value of age

            Console.WriteLine("Please enter the month you were born in from 1= January through 12 = December");
            bMonth = int.Parse(Console.ReadLine());
            //  Console.WriteLine(bMonth); //testing value of bmonth

            //ask the user for their favorite color using roygbiv; if they press help, explain the acronym and ask again
            //if they don't press help, display their favorite color
            //this code only allows them to enter help once, I'm not sure how YET to go back and run the choices again
            //if they enter help a second time, favColor = help, or if they leave it blank favColor is blank

            Console.WriteLine("Please tell me your favorite color of the rainbow from the choices ROYGBIV. If you don't understand the question, please type Help");
            favColor = Console.ReadLine().ToLower();
            // Console.WriteLine(favColor); //testing value of favColor 

            if ((favColor == "help"))
            {
                Console.WriteLine("roygbiv is an acronym for the colors of the rainbow. r=red, o=orange, y=yellow, g=green, b=blue, i=indigo, v=violet.");
                Console.WriteLine();
                Console.WriteLine("Now, please enter your favorite color");
                favColor = Console.ReadLine().ToLower();
             //   Console.WriteLine("My favorite color is also " + favColor + "!");
            }
            //else if ((favColor != "help"))
            //{
            //    Console.WriteLine("My favorite color is also " + favColor + "!");
            //}


            Console.WriteLine("Now please tell me how many siblings do you have");
            numSibs = int.Parse(Console.ReadLine());
            //     Console.WriteLine(numSibs); testing value of age

            // Now we'll calculate the years to retirement based on the user's age
            // if age can be evenly divided by 2 then age is even, otherwise it's odd
            // even years can retire in 20 years; odd years can retire in 25 years

            if (age % 2 == 0)
            {
                evenOrOdd = "even";
                yearsToRetire = 20;
            //    Console.WriteLine(evenOrOdd + yearsToRetire);
            }
            else
            {
                evenOrOdd = "odd";
                yearsToRetire = 25;
            //    Console.WriteLine(evenOrOdd + yearsToRetire);
            }

            //now we'll choose a vacation home based on the number of siblings the user has


            
            switch (numSibs)
            {

                case 0:
                    vacHome = "Brown's Stadium";
                //    Console.WriteLine(vacHome);
                    break;


                case 1:
                    vacHome = "Sandusky";
                //    Console.WriteLine(vacHome);
                    break;

                case 2:
                    vacHome = "Miami Beach";
                //    Console.WriteLine(vacHome);
                    break;

                case 3:
                    vacHome = "Disney Land";
                 //   Console.WriteLine(vacHome);
                    break;

                default:
                    if (numSibs < 0)
                    {
                        vacHome = "rest room at Denny's";
               //         Console.WriteLine(vacHome);
                    }
                    else if (numSibs > 3)
                    {
                        vacHome = "Hilton Head";
                 //       Console.WriteLine(vacHome);
                    }
                    break;
            }
            

            //now we'll assign transportation based on favorite color, this works whether they type red or they type r

            switch (favColor)
            {

                case "red":
                    transportation = "Bus";
               //     Console.WriteLine(transportation);
                    break;

                case "r":
                    transportation = "Bus";
                    //     Console.WriteLine(transportation);
                    break;

                case "orange":
                    transportation = "Yugo";
               //     Console.WriteLine(transportation);
                    break;

                case "o":
                    transportation = "Yugo";
                    break;

                case "yellow":
                    transportation = "Honda Fit";
                //    Console.WriteLine(transportation);
                    break;

                case "y":
                    transportation = "Honda Fit";
                    //    Console.WriteLine(transportation);
                    break;

                case "green":
                    transportation = "Row Boat";
               //     Console.WriteLine(transportation);
                    break;

                case "g":
                    transportation = "Row Boat";
                    //     Console.WriteLine(transportation);
                    break;

                case "blue":
                    transportation = "Rolls Royce";
               //     Console.WriteLine(transportation);
                    break;

                case "b":
                    transportation = "Rolls Royce";
                    //     Console.WriteLine(transportation);
                    break;

                case "indigo":
                    transportation = "Airplane";
               //     Console.WriteLine(transportation);
                    break;

                case "i":
                    transportation = "Airplane";
                    //     Console.WriteLine(transportation);
                    break;

                case "violet":
                    transportation = "Horse Drawn Wagon";
                //    Console.WriteLine(transportation);
                    break;

                case "v":
                    transportation = "Horse Drawn Wagon";
                    //    Console.WriteLine(transportation);
                    break;

                default:  //if the user entered help more than once or left favorite color blank or entered a non roygbiv color, e.g. black
                    transportation = "Skateboard";
                  //  Console.WriteLine("I'm afraid you'll have to walk, clearly you either don't know your colors or can't follow directions!");
                    break;
            }

            // now we'll assign bank account by birth month

            if ((bMonth > 0) && (bMonth <= 4))
            {
                bankAccount = "10,0000";
            //    Console.WriteLine(bankAccount);
            }
            else if ((bMonth >= 5) && (bMonth <= 8))
            {
                bankAccount = "50,000";
            //    Console.WriteLine(bankAccount);
            }
            else if ((bMonth >= 9) && (bMonth <= 12))
            {
                bankAccount = "20,000";
            //    Console.WriteLine(bankAccount);
            }
            else if ((bMonth < 1) || (bMonth > 12))       
            { 
                bankAccount = "0.00";
            //    Console.WriteLine(bankAccount);
            }



            // Let's tell the user their fortune!

            Console.WriteLine();
            Console.WriteLine();
             Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.", fName, lName, yearsToRetire, bankAccount, vacHome,  transportation); 

        }
    }
}
