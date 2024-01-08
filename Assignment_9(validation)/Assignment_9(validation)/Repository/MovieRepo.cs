using Assignment_9_validation_.Model;

namespace Assignment_9_validation_.Repository
{
    public class MovieRepo : ImovieRepo
    {
        List<Movie> movie_List = new List<Movie>();
        public void AddMovie()
        {
            movie_List.Add(new Movie());
            
        }

        public List<Movie> GetAllMovies()
        {
            return movie_List;
        }

        public Movie GetMovieByName(string MovName)
        {
            //List <Movie> MovNameList = new List<Movie> ();
            foreach (var k in movie_List)
            {
                if(k.MovieName == MovName)
                {
                    return k;
                }
               
            }
            return null;
           
        }

        public Movie GetMoviesByActor()
        {
            throw new NotImplementedException();
        }

        public Movie GetMoviesByDirector()
        {
            throw new NotImplementedException();
        }

        public Movie GetMoviesByReleaseYear()
        {
            throw new NotImplementedException();
        }
    }
}
