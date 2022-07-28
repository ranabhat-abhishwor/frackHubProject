using FrackerHub.Entities;
using FrackerHub.Repositories.Interfaces;
using FrackerHub.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrackerHub.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly IRepository<Item> _itemRepo;
        private readonly IRepository<UserItem> _userItemRepo;

        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<ItemType> _itemTypeRepo;
        private readonly IRepository<Asset> _assetRepo;
       // private readonly IRepository<UserItem> _userItemRepo;


        

        public CatalogService(IRepository<Item> itemRepo, IRepository<Category> categoryRepo, IRepository<ItemType> itemTypeRepo, IRepository<Asset> assetRepo, IRepository<UserItem> userItemRepo)

        {
            _itemRepo = itemRepo;
            _categoryRepo = categoryRepo;
            _itemTypeRepo = itemTypeRepo;
            _assetRepo = assetRepo;
            _userItemRepo = userItemRepo;
        }

        public void AddAsset(Asset asset)
        {
            _assetRepo.Add(asset);
            _assetRepo.SaveChanges();
        }

        public void AddAsset()
        {
            throw new NotImplementedException();
        }

        public void AddItem(Item item)
        {
            _itemRepo.Add(item);
            _itemRepo.SaveChanges();            
        }


        public void AddItem()
        {
            throw new NotImplementedException();
        }

        public void AddUserItem(UserItem usritem)
        {
            _userItemRepo.Add(usritem);
            _userItemRepo.SaveChanges();
        }

        public void DeleteAsset()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            _itemRepo.Find(id);
            _itemRepo.SaveChanges();
        }

        public IEnumerable GetAllItemsByUser(string usrEmail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllItemsUploaded()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return  _categoryRepo.GetAll();
        }

        public Item GetItem(int id)
        {
            return _itemRepo.Find(id);        
        }

        public IEnumerable<Item> GetItems()
        {
            return _itemRepo.GetAll().OrderBy(item => item.CategoryId).ThenBy(item => item.itemTypeId);
        }

        public IEnumerable<UserItem> GetItemsByUserEmail(string email)
        {
            return _userItemRepo.GetAll().Where(item => item.UserLogin == email);
        }

        public IEnumerable<ItemType> GetItemTypes()
        {
            return _itemTypeRepo.GetAll();
        }

        public void UpdateAsset()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            _itemRepo.Update(item);
            _itemRepo.SaveChanges();
        }

        //public void UpdateItem(Item item)
        //{
        //    throw new NotImplementedException();
        //}
    }
    
    
}
