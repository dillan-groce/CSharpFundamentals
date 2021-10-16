using _08_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContentInheritence
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }

        public Movie()
        {

        }
        public Movie(string title, string description, double starRating, MaturityRating maturityRating, GenreType typeOfGenre, double runTime)
            : base(title, description, starRating, maturityRating, typeOfGenre)
        {
            RunTime = runTime;
        }
    }
}
