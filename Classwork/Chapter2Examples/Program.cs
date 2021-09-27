// James Hooper
// Chapter2Examples
// 9/21/2021
// Gamedev 1st

// tested by: Jaxon Snow 10/10 loved the sending a reward part

// Tested by Sarah Gubler. The code is clumped and had build errors. 0%

// I fixed it - James

// imports section
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter2Examples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // asking questions and adding them to an array
            String[] data = new string[20];
            Console.WriteLine("What is your first name?");
            String name1 = Console.ReadLine();
            data[0] = name1;
            Console.WriteLine("What is your Last name?");
            String name2 = Console.ReadLine();
            data[1] = name2;
            Console.WriteLine("What is your Phone Number?");
            String phoneNum = Console.ReadLine();
            data[2] = phoneNum;
            Console.WriteLine("What is your Address?");
            String address = Console.ReadLine();
            data[3] = address;
            Console.WriteLine("What is your Social Security Number?");
            String socialSecurityNum = Console.ReadLine();
            data[4] = socialSecurityNum;
            Console.WriteLine("What is your Bank Account number?");
            String bankAccNum = Console.ReadLine();
            data[5] = bankAccNum;
            Console.WriteLine("What is your Credit card number?");
            String creditCardNum = Console.ReadLine();
            data[6] = creditCardNum;
            Console.WriteLine("What is your Favorite Candy?");
            String favCandy = Console.ReadLine();
            data[7] = favCandy;
            Console.WriteLine("What is your Pets name?");
            String petName = Console.ReadLine();
            data[8] = petName;
            Console.WriteLine("What is your favorite place to get Chicken Nuggets?");
            String favChickenNugget = Console.ReadLine();
            data[9] = favChickenNugget;
            Console.WriteLine("What is your favorite kind of Rock?");
            String favRock = Console.ReadLine();
            data[10] = favRock;
            Console.WriteLine("What is your Password?");
            String password = Console.ReadLine();
            data[11] = password;
            Console.WriteLine("What is your favorite Star Wars Movie?");
            String favStarWarsMovie = Console.ReadLine();
            data[12] = favStarWarsMovie;
            Console.WriteLine("What is your favorite Star Wars Character?");
            String favStarWarsChar = Console.ReadLine();
            data[13] = favStarWarsChar;
            Console.WriteLine("What is your favorite Ice Cream?");
            String favIceCream = Console.ReadLine();
            data[14] = favIceCream;
            Console.WriteLine("What is your favorite Licorice?");
            String favLicorice = Console.ReadLine();
            data[15] = favLicorice;
            Console.WriteLine("What is your favorite Element?");
            String favElement = Console.ReadLine();
            data[16] = favElement;
            Console.WriteLine("Does Gas have Mass?????");
            String gasMass = Console.ReadLine();
            data[17] = gasMass;
            Console.WriteLine("What is 2 + 1?");
            String math = Console.ReadLine();
            data[18] = math;
            Console.WriteLine("Is a Hot Dog a Sandwitch?????");
            String hotDog = Console.ReadLine();
            data[19] = hotDog;
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Is supposed to be printing the array but doesnt
            foreach (String i in data)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Thanks for you info, Sending you a reward");

            Console.ReadLine();
        }
    }
}
