using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_MovieLists
{
    public class MovieGenre 
    {
        public static List<Movie> getMovies()
        {
            List<Movie> MovieLibrary = new List<Movie>();

            MovieLibrary.Add(new Movie("Die Hard", "Action"));
            MovieLibrary.Add(new Movie("The Dark Knight", "Action"));
            MovieLibrary.Add(new Movie("Inception", "Action"));
            MovieLibrary.Add(new Movie("Kill Bill: Vol. 1", "Action"));
            MovieLibrary.Add(new Movie("Gladiator", "Action"));

            MovieLibrary.Add(new Movie("White Men Can't Jump", "Comedy"));
            MovieLibrary.Add(new Movie("Anchorman", "Comedy"));
            MovieLibrary.Add(new Movie("Superbad", "Comedy"));
            MovieLibrary.Add(new Movie("Airplane", "Comedy"));
            MovieLibrary.Add(new Movie("Knocked Up", "Comedy"));

            MovieLibrary.Add(new Movie ("The Notebook", "Romance"));
            MovieLibrary.Add(new Movie("When Harry Met Sally", "Romance"));
            MovieLibrary.Add(new Movie("Hitch", "Romance"));
            MovieLibrary.Add(new Movie("Titanic", "Romance"));
            MovieLibrary.Add(new Movie("Sleepless In Seattle", "Romance"));

            MovieLibrary.Add(new Movie ("The Lion King", "Family"));
            MovieLibrary.Add(new Movie("The Jungle Book", "Family"));
            MovieLibrary.Add(new Movie("The Monster's Inc.", "Family"));
            MovieLibrary.Add(new Movie("Aladdin", "Family"));
            MovieLibrary.Add(new Movie("The Little Mermaid", "Family"));

            MovieLibrary.Add(new Movie ("Eternal Sunshine on a Spotless Mind", "Drama"));
            MovieLibrary.Add(new Movie("The Shawshank Redemption", "Drama"));
            MovieLibrary.Add(new Movie("The Help", "Drama"));
            MovieLibrary.Add(new Movie("Forest Gump", "Drama"));
            MovieLibrary.Add(new Movie("A Beautiful Mind", "Drama"));

            MovieLibrary.Add(new Movie ("The Exorcist", "Horror"));
             MovieLibrary.Add(new Movie ("Nightmare on Elmstreet", "Horror"));
             MovieLibrary.Add(new Movie ("Carrie", "Horror"));
             MovieLibrary.Add(new Movie ("Halloween", "Horror"));
            MovieLibrary.Add(new Movie("The Shining", "Horror"));
            



            return MovieLibrary;
        }
    }



    }


