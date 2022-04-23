using EjemploEF.Data;
using EjemploEF.Models;
using EjemploEF.Service;
using Microsoft.EntityFrameworkCore;

namespace EjemploEF.Repository
{
    public class EnrrollmentsRepository :IEnrrollments
    {
        private ApplicationDBContext _Db;

        public EnrrollmentsRepository(ApplicationDBContext bd)
        {
            _Db = bd;
        }

        public IEnumerable<Enrrollments> GetInnerJoin()
        {
            var Join = _Db.Enrrollments
                 .Include(e => e.Student)
                 .Include(c => c.Course).
                 ToList();

            return Join;
        }
    }
}
