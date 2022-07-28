using FrackerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrackerHub.Services.Interfaces
{
    public interface IUserServices
    {
        Task<string> GetUser(User user);

        int CountAllUploadedItems();

        int CountAllUploadedItemsApproved();

        int CountAllUploadedItemsNotApproved();

        int CountAllUploadedItemsRejected();



        IEnumerable<UserItem> UploadedItem();

       
        

        void DisplayLentItems(int Id);

        void DisplayBorrowedItems(int Id);

        void AddAnItem(UserItem userItem);

        void EditUploadedItem(UserItem userItem);

        void DeleteItem(int Id);

        UserItem GetItem(int Id);

    }
}
