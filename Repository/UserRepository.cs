using Dental_Clinic.Context;
using Dental_Clinic.Interfaces.Users;
using Dental_Clinic.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Users> FindByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Login == email);
        }

        public async Task<List<Users>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<Users> GetById(int id)
        {
            return await _context.Users.FirstAsync(x => x.Id == id);
        }

        public async void Insert(Users entity)
        {
            try
            {
                await _context.Users.AddAsync(entity);
                Save();
            }
            catch (Exception)
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
            catch (Exception)
            {
                throw;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Users entity)
        {
            _context.SaveChanges();
        }
    }
}
