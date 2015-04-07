using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBucketHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<String, int> collection = new HashTable<String, int>(101);

            collection.Insert("one", 1);
            collection.Insert("two", 2);
            collection.Insert("three", 3);
            collection.Insert("four", 4);
            collection.Insert("five", 5);
            collection.Insert("six", 6);
            collection.Insert("bier", 8);
            collection.Insert("Patrick", 19);

            Console.WriteLine("eerste invoer:");
            collection.Display();
            collection.Remove("bier");
            Console.WriteLine("na verwijderen:");
            collection.Display();
            Console.ReadLine();
        }
    }

    // Generic collection klasse met Key, Value
    // klasse wordt gebruikt om een Generic key/value object te maken
    // en hierbij meteen een nieuw key/value object te maken als bucket.
    class Node<T, U>
    {
        public T key;                                   // de key
        public U value;                                 // de value
        public Node<T, U> next;                         // het volgende object
        public Node(T key, U value, Node<T, U> next)
        {
            this.key = key;
            this.value = value;
            this.next = next;
        }
    }

    public class HashTable<T, U>
    {
        int length;                 // lengte van de collection
        Node<T, U>[] buckets;       // key value collection
        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node<T, U>[length];
        }

        // Weergeven van alle object in de collectie
        public void Display()
        {
            for (int bucket = 0; bucket < buckets.Length; bucket++)
            {
                Node<T, U> current = buckets[bucket];   // kopieert de inhoud van de ingegeven index naar een nieuwe node.
                Console.Write(bucket + ":");
                while (current != null)
                {
                    Console.Write("[" + current.key + "," + current.value + "]");
                    current = current.next; // pakt de volgende node.
                }
                Console.WriteLine();
                

            }
            //Console.ReadLine();
        }

        // De hashfunctie om de key van het object om te zetten naar een int.
        private int Hash(T Tkey)
        {
            int hashValue = 0;
            hashValue = Math.Abs(Tkey.GetHashCode()); // Gebruikt de .Net getHashCode() om de HashCode te berekenen.
            hashValue = hashValue % buckets.GetUpperBound(0);
            if (hashValue < 0)
            {
                hashValue = hashValue * -1;
            }
            return hashValue;

        }

        // Toevoegen van een object aan de collectie.
        public void Insert(T key, U value)
        {
            int bucket = Hash(key);
            buckets[bucket] = new Node<T, U>(key, value, buckets[bucket]); // object op de juiste plaats zetten en een nieuwe bucket maken.
        }

        // Zoeken naar waarde in de collectie.
        public U Search(T key)
        {
            Node<T, U> current = buckets[Hash(key)];
            while (current != null)
            {
                if (current.key.Equals(key))
                    return current.value;
                current = current.next;
            }
            throw new Exception(key + "Not found");
        }

        public void Remove(T key)
        {
            int hashValue;
            hashValue = Hash(key);
            Node<T, U> previous = null;
            for (Node<T, U> extra = buckets[hashValue]; extra != null; extra = extra.next)
            {
                if ((hashValue == extra.GetHashCode()))
                {
                    buckets[hashValue] = null;
                }
            }

            
        }

    }


}
