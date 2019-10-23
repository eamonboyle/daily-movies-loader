using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiStuff
{
    class SimilarMoviesObject
    {
        public int page { get; set; }
        public SimilarMovie[] results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}
