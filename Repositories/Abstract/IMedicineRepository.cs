using Entities.Models;

namespace Repositories.Abstract
{
    public interface IMedicineRepository
    {
        void add(Medicine medicine);
        void update(Medicine medicine);
        void delete(int id);
    }
}