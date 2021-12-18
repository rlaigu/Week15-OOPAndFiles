using System;
using System.IO;
using System.Collections.Generic;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string present;

            public Frozen(string _name, string _present)
            {
                name = _name;
                present = _present;
            }

            public string Name
            {
                get { return name; }
            }

            public string Present
            {
                get { return present; }
            }

        }
        static void Main(string[] args)
        {
            //Anna wants new earrings for Christmas

            List<Frozen> myFrozen = new List<Frozen>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newFrozen);
            }

            foreach (Frozen frozenFromList in myFrozen)
            {
                Console.WriteLine($"{frozenFromList.Name} wants {frozenFromList.Present} for Christmas.");
            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\sample\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
