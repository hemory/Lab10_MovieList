using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_MovieLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieLibrary = MovieGenre.getMovies();

            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine("There are 30 Movies in the list \n");

            string userContinue;
            do
            {
                Console.WriteLine("What category are you interested in? \n(Enter Action, Drama, Comedy, Romance, or Family)");
                string movieCategory = Console.ReadLine();

                int countOfMoviesFoundInCategory = 0;
                foreach (Movie individualMovie in MovieLibrary)
                {
                    if (individualMovie.Category.ToLower() == movieCategory.ToLower())
                    {
                        countOfMoviesFoundInCategory++;
                        Console.WriteLine(individualMovie.Title);
                    }
                    if (countOfMoviesFoundInCategory == 3)
                    {
                        break;
                    }
                }

                Console.WriteLine("Continue? (y/n)");
                userContinue  = Console.ReadLine();
            } while (userContinue == "y");
    

        }
    }
}

