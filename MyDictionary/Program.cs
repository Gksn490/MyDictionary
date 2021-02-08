using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> filmler = new MyDictionary<string, string>();
            filmler.Add("Orson Welles", "Citizen Kane");
            filmler.Add("Alfred Hitchcock","Psycho");
            filmler.Add("Sidney Lumet","12 Angry Man");

            filmler.List();
        }
    }
}
