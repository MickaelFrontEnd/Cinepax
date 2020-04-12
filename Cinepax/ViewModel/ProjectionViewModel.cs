using System.Collections.Generic;
using Cinepax.Models;

namespace Cinepax.ViewModel
{
    public class ProjectionViewModel
    {
        public int Page { get; set; }
        public int TotalResult { get; set; }
        public List<Projection> Projections { get; set; }
        public string Terms { get; set; }
    }
}
