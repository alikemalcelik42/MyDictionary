using System;

namespace MyDictionary
{

    class Dictionary<TKey, TValue>
    {
        public TKey[] keys;
        public TValue[] values;

        public Dictionary()
        {
            this.keys = new TKey[0];
            this.values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] rekeys = this.keys;
            TValue[] revalues = this.values;

            int count = keys.Length;

            this.keys = new TKey[count + 1];
            this.values = new TValue[count + 1];

            for(int i = 0; i < count; i++)
            {
                this.keys[i] = rekeys[i];
                this.values[i] = revalues[i];
            }

            this.keys[count] = key;
            this.values[count] = value;
        }

        public TValue Get(TKey key)
        {
            int index = 0;

            for(int i = 0; i < this.keys.Length; i++)
            {
                if (this.keys[i].Equals(key))
                {
                    index = i;
                    break;
                }
            }

            return this.values[index];
        }

        public int GetLength()
        {
            return keys.Length;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Ali", 20);
            dictionary.Add("Veli", 30);
            Console.WriteLine(dictionary.Get("Ali"));
        }
    }
}
