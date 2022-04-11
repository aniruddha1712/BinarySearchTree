﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class MyBinarySearchTree<T> where T:IComparable
    {
        public T nodeData { get; set; }
        public MyBinarySearchTree<T> leftTree { get; set; }
        public MyBinarySearchTree<T> rightTree { get; set; }
        public MyBinarySearchTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;

        public void Insert(T data)
        {
            T currentNodeValue = nodeData;
            if ((data.CompareTo(currentNodeValue)) < 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinarySearchTree<T>(data);
                }
                else
                    this.leftTree.Insert(data);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinarySearchTree<T>(data);
                }
                else
                    this.rightTree.Insert(data);
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                leftCount++;
                this.leftTree.Display();
            }
            Console.Write(this.nodeData.ToString() + " ");
            if (this.rightTree != null)
            {
                rightCount++;
                this.rightTree.Display();
            }
        }
        public void SIze()
        {
            Console.WriteLine("\nSize of Binary Tree is: " + (this.leftCount + this.rightCount + 1));
        }
    }
}
