using FrackerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrackerHub.Services.Interfaces
{
    public interface IAdminService
    {
        //void GetUsers();
        void GetUser(int Id);
        IEnumerable<User> GetAllUsers();

        Task <User> ApproveUserRegistration(string Id);

        void DeclineUserRegistration(string Id);

        void BlockUser(int Id);

        void ApproveUserAsset(int Id);

        void RejectUserAsset(int Id);

        void GetTop5NewUploads();





    }
}
