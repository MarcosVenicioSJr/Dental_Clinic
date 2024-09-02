using Dental_Clinic.Jsons.Request;
using Dental_Clinic.Models;

namespace Dental_Clinic.Mapper
{
    public static class MapperUser
    {
        public static Users CreateUserMapper(CreateUserRequest request)
        {
            return new Users
            {
                Login = request.Login,
                Password = request.Password,
            };
        }
    }
}
