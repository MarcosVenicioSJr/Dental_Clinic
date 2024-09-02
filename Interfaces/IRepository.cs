namespace Dental_Clinic.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
        void Save();
    }
}
