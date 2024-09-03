using Azure.Core;
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

        public void CreateUserByList(List<CreateUserRequest> listUserRequest)
        {
            List<Models.Users> listUsers = new List<Models.Users>();

            foreach (var userRequest in listUserRequest)
            {
                Models.Users entity = MapperUser.CreateUserMapper(userRequest);
                listUsers.Add(entity);
            }

            _repository.InsertList(listUsers);
        }
    }
}
