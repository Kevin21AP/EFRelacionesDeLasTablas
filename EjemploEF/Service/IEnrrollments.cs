using EjemploEF.Models;

namespace EjemploEF.Service
{
    public interface IEnrrollments
    {
        IEnumerable<Enrrollments> GetInnerJoin();
    }
}
