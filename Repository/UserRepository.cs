using Dental_Clinic.Context;
using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Models;
using System;

namespace Dental_Clinic.Repository
{
    public class UserRepository : IRepositoryUsers
    {
        private readonly DentalClinicContext _context;

        public UserRepository(DentalClinicContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async void Insert(Users entity)
        {
            try
            {
                await _context.Users.AddAsync(entity);
                Save();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async void InsertList(List<Users> users)
        {
            try
            {
                await _context.Users.AddRangeAsync(users);
                Save();
            }
            catch (Exception ex)
            {
                throw;
            }

            //throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
