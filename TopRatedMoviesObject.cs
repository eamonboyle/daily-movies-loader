using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiStuff
{
    class TopRatedMoviesObject
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public TopRatedMoviesResults[] results { get; set; }
    }
}
