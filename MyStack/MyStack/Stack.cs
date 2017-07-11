using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class Stack<T>
    {
        private int size;
        private List<T> storage;
        private int pointer;

        public int Size { get => size; set => size = value; }
        public int Pointer { get => pointer; set => pointer = value; }
        public List<T> Storage { get => storage; set => storage = value; }

        public Stack(int size)
        {
            Storage = new List<T>();
            pointer = 0;
        }

        public void Push(T item)
        {
            if (Storage.Count <= size)
            {
                Storage.Add(item);
                ++pointer;
            }
            else
            {
                throw new ArgumentException("MyStack is full, cannot push item to it.");
            }
        }

        public T Pop()
        {
            T lastItem = Storage[Storage.Count - 1];
            if (Storage.Count == 0)
            {
                throw new ArgumentException("MyStack is empty, cannot pop item from it.");
            }
            else
            {
                Storage.RemoveAt(Storage.Count - 1);
                return lastItem;
            }
        }

        public T Peek()
        {
            return Storage[Storage.Count - 1];
        }
        
        public int NumOfFreeSpaces()
        {
            return size - Storage.Count;
        }


        static void Main(string[] args)
        {
        }
    }
}
