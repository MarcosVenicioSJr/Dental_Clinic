namespace Dental_Clinic.Interfaces.Users
{
    public interface IRepositoryUsers : IRepository<Models.Users>
    {
        void InsertList(List<Models.Users> users);
    }
}
