using Assignment_9_validation_.Model;

namespace Assignment_9_validation_.Repository
{
    public interface ImovieRepo
    {
        public void AddMovie();
        public List<Movie> GetAllMovies();

        public Movie GetMovieByName(string MovName);
        public Movie GetMoviesByActor();

        public Movie GetMoviesByReleaseYear();
        public Movie GetMoviesByDirector();
    }
}
