
using System.Collections.Generic;
using Cinepax.Models;
using System.Linq;

namespace Cinepax.Services
{
    public class ProjectionService
    {
        public List<Projection> GetProjection(string terms, int page ,out int totalResult)
        {
            List<Projection> result = new List<Projection>();
            using(CinepaxContext cinepaxContext = new CinepaxContext())
            {
                var query = cinepaxContext
                    .Projections
                    .Include("Movie")
                    .Include("Room")
                    .Where(x => x.Movie.Name.Contains(terms));

                // Get total result
                totalResult = query.Count();

                // 

                result = query
                    .OrderBy(x => x.ProjectionDate)
                    .Skip(Utils.GetOffset(page, 8))
                    .Take(8)
                    .ToList();
            }
            return result;
        }

        public Projection GetProjection(int id)
        {
            using (CinepaxContext cinepaxContext = new CinepaxContext())
            {
                return cinepaxContext
                    .Projections
                    .Include("Movie")
                    .Include("Room")
                    .Single(item => item.ID == id);
            }
        }
    }
}
