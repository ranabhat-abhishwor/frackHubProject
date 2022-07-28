using FrackerHub.Entities;
using FrackerHub.Repositories.Interfaces;
using FrackerHub.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrackerHub.Services.Implementations
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Item> _itemRepo;
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<ItemType> _itemTypeRepo;
        protected UserManager<User> _userManager;
//        protected UserManager<User> _userManager;


        public AdminService(UserManager<User> userManager, IRepository<Item> itemRepo, IRepository<Category> categoryRepo, IRepository<ItemType> itemTypeRepo)
        {
            _itemRepo = itemRepo;
            _categoryRepo = categoryRepo;
            _itemTypeRepo = itemTypeRepo;
            _userManager = userManager;
        }
        public void ApproveUserAsset(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> ApproveUserRegistration(string Id)
        {

            //return  await _userManager.FindByIdAsync(Id);

            User result = await _userManager.FindByIdAsync(Id);

            if (result.Approved == 0)
            {
                result.Approved = 1;
                //User result2 = new User
                //{
                //    Id = result.Id,
                //    Approved = 1
                //};

                await _userManager.UpdateAsync(result);
                return result;
            }
            return result;
        }

        public void BlockUser(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeclineUserRegistration(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeclineUserRegistration(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userManager.Users;
        }

        public void GetTop5NewUploads(Item item)
        {
            _itemRepo.Add(item);
            //_itemRepo.        
        }

        public void GetTop5NewUploads()
        {
            throw new NotImplementedException();
        }

       

        public void GetUsers()
        {

            throw new NotImplementedException();
        }

        public void RejectUserAsset(int Id)
        {
            throw new NotImplementedException();
        }

        void IAdminService.GetUser(int Id)
        {
            throw new NotImplementedException();
        }

      
    }
}
