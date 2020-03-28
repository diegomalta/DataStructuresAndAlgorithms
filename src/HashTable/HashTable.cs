using System;
using System.Collections.Generic;

namespace HashTable
{
    public class KeyValuePair
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }

    public class HashTable
    {
        public LinkedList<KeyValuePair>[] hashCollection;

        public HashTable()
        {
            hashCollection = new LinkedList<KeyValuePair>[5];
        }

        public void Put(int key, string value)
        {

            var bucket = GetOrCreateBuket(key);

            if (FindItem(bucket, key) != null)
                return;

            bucket.AddLast(new KeyValuePair { Key = key, Value = value });
        }

        public string Get(int key)
        {
            return FindItem(GetBucket(key), key)?.Value;
        }

        public void Remove(int key)
        {
            var bucket = GetBucket(key);

            var item = FindItem(bucket, key);
            if (item != null)
                bucket.Remove(item);
        }

        private LinkedList<KeyValuePair> GetBucket(int key)
        {
            int hash = GetHash(key);
            return hashCollection[hash];
        }

        private LinkedList<KeyValuePair> GetOrCreateBuket(int key)
        {
            int hash = GetHash(key);
            if (hashCollection[hash] == null)
                hashCollection[hash] = new LinkedList<KeyValuePair>();
            return hashCollection[hash];
        }

        private KeyValuePair FindItem(LinkedList<KeyValuePair> bucket, int key)
        {
            if(bucket != null)
            {
                foreach (var item in bucket)
                {
                    if (item.Key == key)
                        return item;
                }
            }            
            return null;
        }

        private int GetHash (int key)
        {
            return key % hashCollection.Length;
        }
    }
}
