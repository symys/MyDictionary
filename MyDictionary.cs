using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MyDictionary<K,V>
    {
        K[] StudentNumber;
        V[] StudentName;


        public MyDictionary()
        {
            StudentNumber = new K[0];
            StudentName = new V[0];
        }

        public void Add(K item1, V item2)
        {
            K[] tempKeyArray = StudentNumber;
            V[] tempValueArray = StudentName;

            StudentNumber = new K[StudentNumber.Length + 1];
            StudentName = new V[StudentName.Length + 1];


            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                 StudentNumber[i] = tempKeyArray[i];
                 StudentName[i] = tempValueArray[i];
            }

            StudentNumber[StudentNumber.Length - 1] = item1;
            StudentName[StudentName.Length - 1] = item2;
        }

        public void List()
        {
            for (int i = 0; i < StudentNumber.Length; i++)
            {
                Console.WriteLine(StudentNumber[i] + " nolu öğrencimiz: " + StudentName[i]);
            }
        }
    }

}
