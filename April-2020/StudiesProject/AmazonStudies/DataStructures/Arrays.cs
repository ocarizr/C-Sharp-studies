using System;
using System.Collections.Generic;

namespace AmazonStudies.DataStructures
{
    interface Data<T> 
    {
        bool TryAdd(T value);
        bool TryRemove(T value);
        int SearchFor(T value);
        T At(int index);
    }

    public class StaticData<T> : Data<T>
    {
        private T[] data;
        private int index;

        public StaticData(int size) 
        { 
            data = new T[size];
            index = 0;
        }

        public T At(int index)
        {
            if (index > 0 && index < data.Length)
            {
                return data[index];
            }

            throw new IndexOutOfRangeException();
        }

        public int SearchFor(T value)
        {
            for(int i = 0; i < data.Length; ++i)
            {
                if(data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryAdd(T value)
        {
            if (index < data.Length)
            {
                data[index] = value;
                ++index;
                return true;
            }

            return false;
        }

        public bool TryRemove(T value)
        {
            return false;
        }
    }

    public class DynamicData<T> : Data<T>
    {
        private List<T> data;

        public DynamicData() { data = new List<T>(); }

        public T At(int index)
        {
            return data[index];
        }

        public int SearchFor(T value)
        {
            return data.FindIndex(item => item.Equals(value));
        }

        public bool TryAdd(T value)
        {
            data.Add(value);
            return true;
        }

        public bool TryRemove(T value)
        {
            if (data.Contains(value))
            {
                data.Remove(value);
                return true;
            }

            return false;
        }
    }

    public class Arrays
    {
        private Data<int> data;
        private int lenght;

        public Arrays(bool isStatic, int size = 0)
        {
            if (isStatic) InitializeStaticArray(size);
            else InitializeDynamicArray();

            lenght = 0;
        }

        public int At(int index)
        {
            if (index >= lenght) throw new IndexOutOfRangeException();

            return data.At(index);
        }

        public bool TryAdd(int value)
        {
            if (data.TryAdd(value))
            {
                ++lenght;
                return true;
            }

            return false;
        }

        public bool TryRemove(int value)
        {
            if (data.TryRemove(value))
            {
                --lenght;
                return true;
            }

            return false;
        }

        public int SearchFor(int value)
        {
            return data.SearchFor(value);
        }

        public int Length() => lenght;

        private void InitializeStaticArray(int size)
        {
            data = new StaticData<int>(size);
        }

        private void InitializeDynamicArray()
        {
            data = new DynamicData<int>();
        }
    }
}
