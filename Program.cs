using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Setters_and_Getters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie2 = new Movie("The unrealeased movie", "Ora", "Cat");


            Console.WriteLine(movie1.title);
            Console.WriteLine(movie1.director);
            Console.WriteLine(movie1.rating);
            Console.WriteLine(movie2.rating);
            //freeze console
            Console.ReadLine();
        }
    }
}
