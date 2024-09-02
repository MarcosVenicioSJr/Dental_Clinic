using Dental_Clinic.Jsons.Request;

namespace Dental_Clinic.Interfaces.Users
{
    public interface IUserServices : IServices
    {
        void CreateUser(CreateUserRequest entity);
    }
}
