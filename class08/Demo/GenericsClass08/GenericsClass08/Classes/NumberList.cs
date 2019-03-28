using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsClass08.Classes
{
    // Creating a generic
    // T = our type that our generic is going to hold
    class NumberList<T> : IEnumerable
    {
        T[] numbers = new T[5];
        int count = 0;

        public void Add(T number)
        {
            if (count == numbers.Length)
            {
                Array.Resize(ref numbers, (numbers.Length * 2));
            }
            numbers[count++] = number;
        }

        public void Remove(T number)
        {
            T[] temp = null;
            //determine how big the array is and if it needs to be resized.
            // make sure we load up the new array with all the values that do not need to be removed.

            numbers = temp;

        }

        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return numbers[i];
            }
        }

        // Magic. Don't Touch.
        // C# 1.0 support
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
