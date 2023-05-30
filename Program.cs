using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace ConsoleApp1
{

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;

        }
    }
    public class BinaryTree
    {
        private Node _root;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            InsertRec(_root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            tree.Insert(64);
            tree.Insert(32);
            tree.Insert(52);
            tree.Insert(41);
            tree.Insert(82);
            tree.Insert(33);
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(87);
            tree.Insert(4);
            tree.Insert(1);
            tree.Insert(5);
            tree.Insert(35);
            tree.DisplayTree();
        }
    }

    /* Random rand = new Random();
    List<int> numbers = new List<int>();
    Stack<int> stack = new Stack<int>();

    // Generate 10 random numbers between 1 and 100
    for (int i = 0; i < 4; i++)
    {
        int randomNumber = rand.Next(1, 101);
        stack.Push(randomNumber);

    }

    Console.WriteLine("Popping numbers off the stack:");

    // Pop each number off the stack and print it
    while (stack.Count > 0)
    {
        int number = stack.Pop();
        Console.WriteLine(number);
    }




    Console.WriteLine();
    Console.WriteLine();

    Queue qt = new Queue();
    List<int> number1 = new List<int>();
    qt.Enqueue(3);
    qt.Enqueue(09);
    qt.Enqueue(5);

    foreach (Object obj in qt)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine(); Console.WriteLine();
    Console.WriteLine("The number of elements in the Queue " + qt.Count);
    */








}