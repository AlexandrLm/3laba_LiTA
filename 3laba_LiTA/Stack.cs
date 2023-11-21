using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3laba_LiTA
{
    
    internal class Stack
    {
        static private int n = 10;
        private int[] data = new int[n];
        private int top;
        public Stack() { 
            top = -1;
        }
        public Stack(int a)
        {
            n = a;
            top = -1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()
        {
            return top == n - 1;
        }
        public int Count()
        {
            return top;
        }
        public int MaxItems()
        {
            return n;
        }
        public void Add(int a)
        {
            try
            {
                if (IsFull())
                    throw new Exception("Переполнение");
                top++;
                data[top] = a;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GetOne()
        {
            try
            {
                if (IsEmpty())
                    throw new Exception("Стек пуст");
                Console.WriteLine(data[top]);
                top--;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
