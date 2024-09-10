namespace Dental_Clinic.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
        void Save();
    }
}
