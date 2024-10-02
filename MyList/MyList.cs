using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T>
    {
        private T[] _mainArray;
        public int Length => _mainArray.Length;

        public T this[int index]
        {
            get => _mainArray[index];
            set => _mainArray[index] = value;
        }

        public MyList()
        {
            _mainArray = new T[0];

        }

        public void Add(T value)
        {
            T[] MainArrayCopy = new T[_mainArray.Length + 1];
            for (int i = 0; i < _mainArray.Length; i++)
            {
                MainArrayCopy[i] = _mainArray[i];
            }
            MainArrayCopy[_mainArray.Length] = value;
            _mainArray = MainArrayCopy;
        }

        public void Clear() => _mainArray = new T[0];

        public bool Contains(T value)
        {
            bool ContainsOrNot = false;
            for (int i = 0; i < _mainArray.Length; i++)
            {
                if (_mainArray[i].Equals(value))
                {
                    ContainsOrNot = true;
                }
            }
            return ContainsOrNot;
        }

        public int IndexOf(T value)
        {
            int IndexNumber = 0;
            for (int i = 0; i < _mainArray.Length; i++)
            {
                if (_mainArray[i].Equals(value))
                {
                    IndexNumber = i;
                }
            }
            return IndexNumber;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < _mainArray.Length)
            {
                T[] MainArrayCopy = new T[_mainArray.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    MainArrayCopy[i] = _mainArray[i];
                }

                for (int i = index + 1; i < _mainArray.Length; i++)
                {
                    MainArrayCopy[i - 1] = _mainArray[i];
                }
                _mainArray = MainArrayCopy;
            }
        }

        public void Remove(T value)
        {
            int AmountOfRemovedValues = 0;
            for (int i = 0; i < _mainArray.Length; i++)
            {
                if (_mainArray[i].Equals(value))
                {
                    AmountOfRemovedValues += 1;
                }
            }
            int RemovedElementsNum = 0;
            T[] MainArrayCopy = new T[_mainArray.Length - AmountOfRemovedValues];
            for (int i = 0; i < _mainArray.Length; i++)
            {
                if (_mainArray[i].Equals(value))
                {
                    RemovedElementsNum += 1;
                }
                else { MainArrayCopy[i - RemovedElementsNum] = _mainArray[i]; }
            }
            _mainArray = MainArrayCopy;
        }

        public void Insert(int index, T value)
        {
            if (index >= 0 && index < _mainArray.Length)
            {
                T[] MainArrayCopy = new T[_mainArray.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    MainArrayCopy[i] = _mainArray[i];
                }
                MainArrayCopy[index] = value;
                for (int i = index + 1; i < _mainArray.Length + 1; i++)
                {
                    MainArrayCopy[i] = _mainArray[i - 1];
                }
                _mainArray = MainArrayCopy;
            }
        }

        public void ShowArray()
        {
            for (int i = 0; i < _mainArray.Length; i++)
            {
                Console.Write(_mainArray[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
