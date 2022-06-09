using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtestDeluxeOfDoom
{
    internal class Movie
    {
        public string Name { get; }
        public string Director { get; }
        public int MovieLengthInMinutes { get; }
        public Actors Actors { get; }
        public Genre Genre { get; }

        public Movie(string name, string director, Actors actors, string genre )
        {
            Name = name;
            Director = director;
            //MovieLengthInMinutes = movieLength;
            Actors = actors;
            if (genre == "Horror")
                Genre = Genre.Horror;
            else if (genre == "Thriller")
                Genre = Genre.Thriller;
            else if (genre == "Naturdokumentation")
                Genre = Genre.Naturodokumentation;
            else if (genre == "Zeichentrickfilm")
                Genre = Genre.Zeichentrickfilm;
            
            else
                Genre = Genre.Undefiniert;

        }

        public void MovieInfo()
        {
            Console.WriteLine("Der Film " + Name + " ist vom Regisseur " + Director+ " mit den Schauspieler/n");
            foreach (Actor act in Actors)
                Console.Write(act.Name+" ");
            Console.Write("und der Film ist ein ");
            if (Genre == Genre.Horror)
                Console.Write("gruseliger");
            else if (Genre == Genre.Thriller)
                Console.Write("spannender");
            else if (Genre == Genre.Komödie)
                Console.Write("lustiger");
            else if (Genre == Genre.Zeichentrickfilm)
                Console.Write("familienfreundlicher");
            else if (Genre == Genre.Naturodokumentation)
                Console.Write("lehrbarer");
            else Console.Write("unbekannter");
            Console.Write(" Film");
        }


    }

    internal enum Genre
    {
        Horror,
        Thriller,
        Komödie,
        Naturodokumentation,
        Zeichentrickfilm,
        Undefiniert
    }
}
 