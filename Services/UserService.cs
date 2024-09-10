using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Jsons.Request;
using Dental_Clinic.Mapper;
using Dental_Clinic.Models;

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
            List<Users> listUsers = new List<Users>();

            foreach (var userRequest in listUserRequest)
            {
                Users entity = MapperUser.CreateUserMapper(userRequest);
                listUsers.Add(entity);
            }

            _repository.InsertList(listUsers);
        }

        public List<Users> GetAll()
        {
            Task<List<Users>> users = _repository.GetAll();
            return users.Result;
        }

        public Users GetById(int id)
        {
            Task<Users> user = _repository.GetById(id);
            return user.Result;
        }

        public void Update(Users entity)
        {
            Users newUser = GetById(entity.Id);

            newUser.Login = entity.Login;
            newUser.Password = entity.Password;

            _repository.Update(newUser);
        }
    }
}
