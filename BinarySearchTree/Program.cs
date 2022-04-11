using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree\n");

            MyBinarySearchTree<int> binarySearchTree = new MyBinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();

            Console.ReadLine();
        }
    }
}
