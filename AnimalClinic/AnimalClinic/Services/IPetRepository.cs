using AnimalClinic.Models;

namespace AnimalClinic.Services
{
    public interface IPetRepository : IRepository<Pet, int>
    {
    }
}
