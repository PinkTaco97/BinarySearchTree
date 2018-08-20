using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree();
        }

        static public void BinaryTree()
        {
            Tree tree = new Tree();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = rand.Next(1, 100);
                tree.AddValue(num);
            }

            tree.Traverse();

            Console.Write("Enter number to search for: ");
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);
            Node search = tree.Search(number);

            if (search != null)
            {
                Console.WriteLine("Found: " + search.value + "\n");
            }
            else
            {
                Console.WriteLine("Not Found :(");
            }

            Console.ReadLine();

            //Clear the console
            Console.Clear();

            BinaryTree();
        }
    }
}
