using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    public class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; }

        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
            Cast = new List<string>();
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(Genre genre)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            string actors = string.Join(", ", Cast);
            return $"Movie: {Title} ({Year}), {Length} mins \n   Genre: {Genre}\n   Starring: {actors}";
        }
    }
}
