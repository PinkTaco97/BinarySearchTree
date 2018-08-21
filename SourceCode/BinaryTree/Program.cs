using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// The Program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The Main function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Do the thing.
            BinaryTree();
        }

        //Dose that thing.
        static public void BinaryTree()
        {
            //Welcome the user.
            Console.WriteLine("Welcome to the Integer Binary Search Tree.");
            Console.WriteLine();

            //Create the Binary Tree.
            Tree tree = new Tree();
            
            //Create a Random number.
            Random rand = new Random();

            //Print to the console.
            Console.WriteLine("Here is 10 random numbers:");

            //Get 10 random numbers.
            for (int i = 0; i < 10; i++)
            {
                //Get the next random number.
                int num = rand.Next(1, 100);

                //Add the number to the Binary Tree.
                tree.AddValue(num);

                //Print the number to the console.
                Console.Write(num);

                //Insert the commas.
                if (i < 9)
                {
                    Console.Write(",");
                }
            }

            //Output to the console.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here they are sorted:");

            //Traverse the tree.
            tree.Traverse();

            Console.Write("\b \b");

            //Output to the console.
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter number to search for: ");

            //Get the input to search.
            string input = Console.ReadLine();
            int number;

            //Convert to int.
            Int32.TryParse(input, out number);

            //Search the Binary Tree.
            Node search = tree.Search(number);

            //New Line.
            Console.WriteLine();

            //If the returned node isnt null.
            if (search != null)
            {
                //We found it.
                Console.WriteLine("Found: " + search.value + " :) \n");
            }
            else
            {
                //Not found.
                Console.WriteLine("Not Found :( \n");
            }

            //Print to the console.
            Console.Write("Press enter to restart...");

            //Pause.
            Console.ReadLine();

            //Clear the console.
            Console.Clear();

            //Restart the Console App.
            BinaryTree();
        }
    }
}
