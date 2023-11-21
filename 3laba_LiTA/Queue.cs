using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3laba_LiTA
{
    internal class Queue
    {
        class Element
        {
            public int data;
            public Element? next = null;
            public Element()
            {
                data = new int();
            }
            public Element(int p)
            {
                data = p;
                next = null;
            }
        }
        Element head = null;
        public void add(int p)
        {
            if (head == null)
            {
                head = new Element(p);
            }
            else
            {
                Element t = head;
                while (t.next != null)
                    t = t.next;
                t.next = new Element(p);
            }
        }
        public void getAll()
        {
            Element t = head;
            if (head == null)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            int i = 1;
            while (t != null)
            {
                Console.Write($"№{i}: ");
                Console.WriteLine(t.data);
                t = t.next;
                i++;
            }
        }
        public void GetOne()
        {
            try
            {
                if (head == null)
                    throw new Exception("Список пуст");
                Console.WriteLine(head.data);
                if (head.next == null)
                    head = null;
                else
                    head = head.next;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void get(int a)
        {
            try
            {          
                if (head == null)
                    throw new Exception("Список пуст");
                Element t = head;
                for (int i = 0; i < a - 1; i++)
                {
                    if (t.next == null)
                        throw new Exception("Такого элемента не существует");
                    else
                        t = t.next;
                }
                Console.WriteLine(t.data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }     
    }
}
