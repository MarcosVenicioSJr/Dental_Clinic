using Dental_Clinic.Interfaces;
using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Models;

namespace Dental_Clinic.Services
{
    public class UserService : IServices
    {
        private readonly IRepositoryUsers _repository;

        public UserService(IRepositoryUsers repository)
        {
            _repository = repository;
        }

        public void CreateUser(Users entity)
        {
            _repository.Insert(entity);
        }
    }
}
