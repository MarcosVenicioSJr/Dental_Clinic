using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Jsons.Request;
using Dental_Clinic.Mapper;

namespace Dental_Clinic.Services
{
    public class UserService : IUserServices
    {
        private readonly IRepositoryUsers _repository;

        public UserService(IRepositoryUsers repository)
        {
            _repository = repository;
        }

        public void CreateUser(CreateUserRequest request)
        {
            Models.Users entity = MapperUser.CreateUserMapper(request);

            _repository.Insert(entity);
        }
    }
}
