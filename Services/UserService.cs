using Microsoft.EntityFrameworkCore;
using ProjectManagement.WebAPI.Contracts;
using ProjectManagement.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Services
{
    public class UserService : IUserService
    {

        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<M_User>> GetAllAsync()
        {
            return await _userRepository.GetAll().ToListAsync();
        }

        public async Task<M_User> GetByIdAsync(int Id)
        {
            return await _userRepository.GetSingleEntityByCondition(x => x.UserId == Id);
        }

        public async Task SaveAsync(M_User user)
        {
            await _userRepository.SaveAsync(user);           
        }


        public async Task UpdateAsync(M_User user)
        {
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteAsync(M_User user)
        {
            await _userRepository.DeleteAsync(user);
        }

       
    }
}
