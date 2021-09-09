using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie pulpFiction = new Movie("Pulp Fiction", 1994, 154);
            pulpFiction.AddActor("John Travolta");
            pulpFiction.SetGenre(Genre.Crime | Genre.Drama);
            pulpFiction.AddActor("Uma Thurman");
            Show s1 = new Show(pulpFiction, Day.Mon, 6.95, new Time(13, 15));

            Console.WriteLine(s1);              //displays one object
            Theater eglinton = new Theater("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();              //displays one object

            Movie inception = new Movie("Inception", 2010, 148);
            inception.AddActor("Leonardo DiCaprio");
            inception.AddActor("Joseph Gordon-Levitt");
            inception.AddActor("Elliot Page");
            inception.SetGenre(Genre.Action | Genre.Adventure | Genre.SciFi);

            Movie fightClub = new Movie("Fight Club", 1999, 139);
            fightClub.AddActor("Brad Pitt");
            fightClub.AddActor("Edward Norton");
            fightClub.SetGenre(Genre.Drama);
            eglinton.AddShow(new Show(fightClub, Day.Sun, 7.87, new Time(18, 5)));

            Movie m1 = new Movie("The Shawshank Redemption", 1994, 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(Genre.Action);
            eglinton.AddShow(new Show(m1, Day.Mon, 9.25, new Time(14, 5)));

            Movie avengers = new Movie("Avengers: Endgame", 2019, 120);
            avengers.AddActor("Robert Downey Jr.");
            avengers.AddActor("Chris Evans");
            avengers.AddActor("Chris Hemsworth");
            avengers.AddActor("Scarlett Johansson");
            avengers.AddActor("Mark Ruffalo");
            avengers.SetGenre(Genre.Action | Genre.Fantasy | Genre.Adventure);
            eglinton.AddShow(new Show(avengers, Day.Sat, 12.25, new Time(21, 5)));

            m1 = new Movie("Forrest Gump", 1994, 142);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Robin Wright");
            m1.SetGenre(Genre.Drama | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Tue, 6.85, new Time(16, 5)));

            m1 = new Movie("Goodfellas", 1990, 146);
            m1.AddActor("Robert De Niro");
            m1.AddActor("Ray Liotta");
            m1.AddActor("Joe Pesci");
            m1.SetGenre(Genre.Biography | Genre.Crime | Genre.Drama);
            eglinton.AddShow(new Show(m1, Day.Sun, 5.80, new Time(16, 5)));

            m1 = new Movie("Interstellar", 2014, 169);
            m1.AddActor("Matthew McConaughey");
            m1.AddActor("Anne Hathaway");
            m1.AddActor("Jessica Chastain");
            m1.SetGenre(Genre.Adventure | Genre.Drama | Genre.SciFi);
            eglinton.AddShow(new Show(m1, Day.Mon, 8.87, new Time(15, 5)));
            eglinton.AddShow(new Show(m1, Day.Tue, 6.50, new Time(13, 15)));

            m1 = new Movie("You've Got Mail", 1998, 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(Genre.Comedy | Genre.Romance);
            eglinton.AddShow(new Show(m1, Day.Sat, 7.55, new Time(15, 5)));

            m1 = new Movie("Saving Private Ryan", 1998, 169);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Matt Damon");
            m1.AddActor("Tom Sizemore");
            m1.SetGenre(Genre.Drama | Genre.War);
            eglinton.AddShow(new Show(m1, Day.Sun, 10.25, new Time(22, 5)));

            Movie theLionKing = new Movie("The Lion King", 1994, 88);
            theLionKing.AddActor("Matthew Broderick");
            theLionKing.AddActor("Jeremy Irons");
            theLionKing.AddActor("James Earl Jones");
            theLionKing.AddActor("Whoopi Goldberg");
            theLionKing.SetGenre(Genre.Adventure | Genre.Animation | Genre.Drama);
            eglinton.AddShow(new Show(theLionKing, Day.Sat, 6.40, new Time(09, 55)));
            eglinton.AddShow(new Show(theLionKing, Day.Sat, 6.50, new Time(11, 05)));

            Movie toyStory4 = new Movie("Toys Story 4", 2019, 89);
            toyStory4.AddActor("Keanu Reeves");
            toyStory4.AddActor("Christina Hendricks");
            toyStory4.AddActor("Tom Hanks");
            toyStory4.AddActor("Tim Allen");
            toyStory4.SetGenre(Genre.Comedy | Genre.Fantasy | Genre.Animation);
            eglinton.AddShow(new Show(toyStory4, Day.Sat, 6.40, new Time(14, 10)));

            eglinton.AddShow(new Show(inception, Day.Sat, 8.45, new Time(12, 50)));
            eglinton.AddShow(new Show(avengers, Day.Mon, 16.15, new Time(23, 10)));
            eglinton.AddShow(new Show(inception, Day.Sun, 7.89, new Time(11)));
            eglinton.AddShow(new Show(toyStory4, Day.Wed, 7.89, new Time(15, 10)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 10.25, new Time(16, 5)));
            eglinton.AddShow(new Show(inception, Day.Tue, 7.89, new Time(16, 10)));
            eglinton.AddShow(new Show(avengers, Day.Thu, 10.25, new Time(11, 20)));
            eglinton.AddShow(new Show(m1, Day.Sat, 10.25, new Time(20, 40)));
            eglinton.AddShow(new Show(inception, Day.Fri, 6.50, new Time(23, 5)));
            eglinton.AddShow(new Show(avengers, Day.Sat, 9.85, new Time(10, 50)));
            eglinton.AddShow(new Show(inception, Day.Thu, 9.50, new Time(21, 45)));
            eglinton.AddShow(new Show(avengers, Day.Sun, 12.75, new Time(19, 30)));
            eglinton.AddShow(new Show(inception, Day.Mon, 6.50, new Time(18, 20)));
            eglinton.AddShow(new Show(avengers, Day.Sun, 12.75, new Time(15, 5)));

            eglinton.PrintShows();                              
            eglinton.PrintShows(Day.Sun);                       
            eglinton.PrintShows(Genre.Action);                  
            eglinton.PrintShows(Genre.Romance);                 
            eglinton.PrintShows(Genre.Action | Genre.Romance);  
            eglinton.PrintShows("Tom Hanks");              

            Time time = new Time(13, 15);
            eglinton.PrintShows(time);                          

            eglinton.PrintShows(Day.Sun, time);                 
        }
    }
}
