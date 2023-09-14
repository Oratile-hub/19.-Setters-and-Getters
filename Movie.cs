using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Setters_and_Getters
{
    internal class Movie
    {
        public string title;
        public string director;
        public string rating;

        //constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating =  aRating;  //now the movie rating is being set by the setter below
        }

        public string Rating 
        { get 
            { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")

                { rating = value;}
                else { rating = "NR"; }
            }
        
        }
       

    }
}
