using GenericsDemo;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(848, "Şeyma Demir");
            myDictionary.Add(1024, "Şeyma Yıldız");
            myDictionary.Add(254, "Ahmet Poyraz");

            myDictionary.List();

        }
    }
}
