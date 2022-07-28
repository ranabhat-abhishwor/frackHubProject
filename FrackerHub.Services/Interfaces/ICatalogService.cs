using FrackerHub.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Services.Interfaces
{
    public interface ICatalogService
    {
        IEnumerable<Category> GetCategories();

        IEnumerable<ItemType> GetItemTypes();

        IEnumerable<Item> GetItems();

        IEnumerable<UserItem> GetItemsByUserEmail(string email);


        IEnumerable GetAllItemsUploaded();
        IEnumerable GetAllItemsByUser(string usrEmail);
        Item GetItem(int id);

        void AddItem(Item item);

        void AddUserItem(UserItem usritem);
        void UpdateItem(Item item);
        void DeleteItem(int id);

        void AddAsset();
        void UpdateAsset();
        void DeleteAsset();

    }
}
