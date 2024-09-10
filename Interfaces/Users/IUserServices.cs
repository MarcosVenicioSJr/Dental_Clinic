using Dental_Clinic.Jsons.Request;

namespace Dental_Clinic.Interfaces.Users
{
    public interface IUserServices : IServices<Models.Users>
    {
        void CreateUser(CreateUserRequest entity);
        void CreateUserByList(List<CreateUserRequest> listUserRequest);
    }
}
