using _08_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContentInheritence
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; }
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRuntime { get; set; }
    }
    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
