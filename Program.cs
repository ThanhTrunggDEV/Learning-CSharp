using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.Threading;
using static System.Math;
using static System.Threading.Thread;
using static ThanhTrung.Advanced;
using System.Globalization;
using System.Data.Common;
using Learning_CSharp.Learning_At_School;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Linq;
using OfficeOpenXml.LoadFunctions.Params;
using System.Runtime.CompilerServices;
namespace Learning_CSharp
{
    public class Node : IComparer<Node>
    {
        public int val;
        public Node next = null;
        public Node(int x)
        {
            val = x;
        }
        public Node() { }
        public int Compare(Node x, Node y)
        {
            if(x.val < y.val) return -1;

            return 1;
        }
    }
    
    public class LinkedList
    {
        public Node head;
        public int length;
        public LinkedList()
        {
            head = null;
            length = 0;
        }
    }

           
    internal class Program
    {
        static void Push_back(int val, LinkedList list)
        {
            Node newNode = new Node(val);
            list.length++;
            Node temp = list.head;
            if (list.head == null)
            {
               list.head = newNode;
                return;
            }
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        static void Pop_back(LinkedList list)
        {
            list.length--;
            Node temp = list.head;
            for(int i = 0; i < list.length - 2; i++)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        static void Remove(LinkedList list, int index)
        {
            
            Node prevNode = list.head;
            Node temp = prevNode.next;
            if (index < 0 || index >= list.length) return;
            list.length--;
            if(index == 0)
            {
                list.head = list.head.next;
                return;
            }
            for (int i = 1;i < list.length; i++)
            {
                if (i == index)
                {
                    prevNode.next = temp.next;
                    return;
                }
                prevNode = temp;
                temp = temp.next;
            }

        }
        static void Insert(LinkedList list, int index, int val)
        {
            if (index < 0 || index >= list.length) return;
            Node newNode = new Node(val);
            list.length++;
            if(index == 0)
            {
                Node temp = list.head;
                list.head = newNode;
                newNode.next = temp;
                return;
            }
            Node node = list.head.next;
            Node prevNode = list.head;
            for(int i = 1; i < list.length; i++)
            {
                if(i == index)
                {
                    prevNode.next = newNode;
                    newNode.next = node;
                    return;
                }
                prevNode = node;
                node = node.next;
            }
        }
        static Node Reverse(LinkedList list)
        {
           Node prevNode = null;
           Node curNode = list.head;
            Node nextNode = curNode.next;
            while(curNode != null)
            {
                nextNode = curNode.next;
                curNode.next = prevNode;
                prevNode = curNode;
                curNode = nextNode;
                
            }
            return prevNode;
        }
        static void Print(LinkedList list)
        {
            Node temp = list.head;
            while (temp != null)
            {
                WriteLine(temp.val);
                temp = temp.next;
            }
        }
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            Generate();
        }
    }
}