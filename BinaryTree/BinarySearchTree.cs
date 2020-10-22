using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {

        public T NodeData { get; set; }

        public BinarySearchTree<T> LeftTree { get; set; }


        public BinarySearchTree<T> RightTree { get; set; }


        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);

                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(item);

                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }

        }

        public void Display()
        {

            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }

        }

        public void GetSize()
        {
            Console.WriteLine("Size  " + (1 + this.leftCount + this.rightCount));

        }

        public bool Search(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element Found In Binary search tree " + node.NodeData);

                result = true;
            }
            else
            {
                Console.WriteLine("Current Element is " + node.NodeData + " in BST");

            }

            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.RightTree);
            }

            return result;

        }

    }

}