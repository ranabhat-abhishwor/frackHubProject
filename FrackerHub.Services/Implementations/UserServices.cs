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
    public class UserServices : IUserServices
    {
        private readonly IRepository<Item> _itemRepo;
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<ItemType> _itemTypeRepo;
        private readonly IRepository<UserItem> _userItemRepo;
        protected UserManager<User> _userManager;


//        protected UserManager<User> _userManager;

        public UserServices(UserManager<User> userManager, IRepository<Item> itemRepo, IRepository<Category> categoryRepo, IRepository<ItemType> itemTypeRepo, IRepository<UserItem> userItemRepo)
        {
            _itemRepo = itemRepo;
            _categoryRepo = categoryRepo;
            _itemTypeRepo = itemTypeRepo;
            _userManager = userManager;
            _userItemRepo = userItemRepo;

        }

        public void AddAnItem(UserItem userItem)
        {

            _userItemRepo.Add(userItem);
            var resp = _userItemRepo.SaveChanges();
            //if (resp)
            //{ }
        }

        public void CountAllUploadedItems(int Id)
        {
            throw new NotImplementedException();
        }

        public int CountAllUploadedItems()
        {
            throw new NotImplementedException();
        }

        public int CountAllUploadedItemsApproved()
        {
            throw new NotImplementedException();
        }

        public int CountAllUploadedItemsNotApproved()
        {
            throw new NotImplementedException();
        }

        public int CountAllUploadedItemsRejected()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int Id)
        {
            var itemForDeletion =_userItemRepo.Find(Id);
            _userItemRepo.Delete(Id);

            var itemForDeletion2 = _userItemRepo.Find(Id);
             _userItemRepo.Remove(itemForDeletion2);
        }

        public void DisplayBorrowedItems(int Id)
        {
            throw new NotImplementedException();
        }

        public void DisplayLentItems(int Id)
        {
            throw new NotImplementedException();
        }

        public void EditUploadedItem(UserItem userItem)
        {
            _userItemRepo.Update(userItem);
            var resp = _userItemRepo.SaveChanges();
        }

        public UserItem GetItem(int Id)
        {
            return _userItemRepo.Find(Id);
        }

        public async Task<string> GetUser(User user)
        {
            return await _userManager.GetUserIdAsync(user);
        }

        public void UploadedItem(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserItem> UploadedItem()
        {
            return _userItemRepo.GetAll();
            //return UserItem;
        }
    }
}
