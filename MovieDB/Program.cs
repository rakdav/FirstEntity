using FirstEntity;

using (MoviesDatabaseContext db=new MoviesDatabaseContext())
{
    List<Movie> list=db.Movies.ToList();
    foreach (Movie movie in list)
        Console.WriteLine(movie.Year+" "+movie.Name+" "+movie.Genre+" "+
            movie.Graduation+" "+movie.Director);
}
