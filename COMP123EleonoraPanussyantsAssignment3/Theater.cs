using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    public class Theater
    {
        private List<Show> shows;
        public string Name { get; }

        public Theater(string name)
        {
            Name = name;
            shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {
            Console.WriteLine($"Theater: {Name} \nAll shows available:");
            int number = 1;
            foreach (Show show in shows)
            {
                Console.WriteLine($"{number}. {show}");
                number++;
            }
        }

        public void PrintShows(Genre genre)
        {
            Console.WriteLine($"Theater: {Name} \nShows with {genre} genre:");
            int number = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{number}. {show}");
                    number++;
                }
            }
        }

        public void PrintShows(Day day)
        {
            Console.WriteLine($"Theater: {Name} \nShows on {day}:");
            int number = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.WriteLine($"{number}. {show}");
                    number++;
                }
            }
        }

        public void PrintShows(Time time)
        {
            Console.WriteLine($"Theater: {Name} \nShows around {time} period:");
            int number = 1;
            foreach (Show show in shows)
            {
                if (show.Time == time)
                {
                    Console.WriteLine($"{number}. {show}");
                    number++;
                }
            }
        }

        public void PrintShows(string actor)
        {
            Console.WriteLine($"Theater: {Name} \nShows with {actor} starring:");
            int number = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{number}. {show}");
                    number++;
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            Console.WriteLine($"Theater: {Name} \nShows on {day}, aroung {time} o'clock:");
            int number = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.WriteLine($"{number}. {show}");
                    number++;
                }
            }
        }
    }
}
