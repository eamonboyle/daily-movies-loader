using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiStuff
{
    class RecommendationsObject
    {
        public int page { get; set; }
        public Recommendation[] results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}
