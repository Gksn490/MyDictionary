using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<D,M>
    {
        D[] Director;
        M[] Movie;

        public MyDictionary()
        {
            Director = new D[0];
            Movie = new M[0];
        }
        
        public void Add(D key, M item)
        {
            D[] tempKeyArray = Director;
            M[] tempValueArray = Movie;

            Director = new D[Director.Length + 1];
            Movie = new M[Movie.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                Director[i] = tempKeyArray[i];
                Movie[i] = tempValueArray[i];

            }

            Director[Director.Length - 1] = key;
            Movie[Movie.Length - 1] = item;
        }
        public void List()
        {
            for (int i = 0; i < Movie.Length; i++)
            {
                Console.WriteLine(Director[i] + " : " + Movie[i]);

            }
        }
    }
}
