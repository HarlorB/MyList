using System;
using System.Collections;
using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(1);
            list.Add("aaa");
            list.Add(1);
            list.Insert(1,false);
            Console.WriteLine(list[0]);

        }
    }
    class MyList
    {
        private System.Object[] _MainArray = new System.Object[0];
        public int lenght = _MainArray.Length;

    public System.Object this[int index]
        {
            get => _MainArray[index];
            set => _MainArray[index] = value;
        }

        public void Add(System.Object value)
        {
            System.Object[] MainArrayCopy = new System.Object[_MainArray.Length + 1];
            for (int i = 0; i < _MainArray.Length; i++)
            {
                MainArrayCopy[i] = _MainArray[i];
            }
            MainArrayCopy[_MainArray.Length] = value;
            _MainArray = MainArrayCopy;
        }

        public void Clear()
        {
            _MainArray = new System.Object[0];
        }

        public bool Contains(System.Object value)
        {
            bool ContainsOrNot = false;
            for (int i = 0; i < _MainArray.Length; i++)
            {
                if (_MainArray[i].Equals(value))
                {
                    ContainsOrNot = true;
                }
            }
            return ContainsOrNot;
        }

        public int IndexOf(System.Object value)
        {
            int IndexNumber = 0;
            for (int i = 0; i < _MainArray.Length; i++)
            {
                if (_MainArray[i].Equals(value))
                {
                    IndexNumber = i;
                }
            }
            return IndexNumber;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < _MainArray.Length)
            {
                System.Object[] MainArrayCopy = new System.Object[_MainArray.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    MainArrayCopy[i] = _MainArray[i];
                }

                for (int i = index + 1; i < _MainArray.Length; i++)
                {
                    MainArrayCopy[i - 1] = _MainArray[i];
                }
                _MainArray = MainArrayCopy;
            }
        }

        public void Remove(System.Object value)
        {
            int AmountOfRemovedValues = 0;
            for (int i = 0; i < _MainArray.Length; i++)
            {
                if (_MainArray[i].Equals(value))
                {
                    AmountOfRemovedValues += 1;
                }
            }
            int RemovedElementsNum = 0;
            System.Object[] MainArrayCopy = new System.Object[_MainArray.Length - AmountOfRemovedValues];
            for (int i = 0; i < _MainArray.Length; i++)
            {
                if (_MainArray[i].Equals(value))
                {
                    RemovedElementsNum += 1;
                }
                else { MainArrayCopy[i - RemovedElementsNum] = _MainArray[i]; }
            }
            _MainArray = MainArrayCopy;
        }

        public void Insert(int index, System.Object value)
        {
            if (index >= 0 && index < _MainArray.Length)
            {
                System.Object[] MainArrayCopy = new System.Object[_MainArray.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    MainArrayCopy[i] = _MainArray[i];
                }
                MainArrayCopy[index] = value;
                for (int i = index + 1; i < _MainArray.Length + 1; i++)
                {
                    MainArrayCopy[i] = _MainArray[i - 1];
                }
                _MainArray = MainArrayCopy;
            }
        }

        public int Lenght()
        {
            return _MainArray.Length;
        }

        public void ShowArray()
        {
            for (int i = 0; i < _MainArray.Length; i++)
            {
                Console.Write(_MainArray[i] + " ");
            }
            Console.Write("\n");
        }



    }
}


