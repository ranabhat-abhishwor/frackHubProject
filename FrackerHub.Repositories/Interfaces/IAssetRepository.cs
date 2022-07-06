using FrackerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Repositories.Interfaces
{
    public interface IAssetRepository
    {
        public Asset GetAsset { get; set; }

        int UploadAsset(Asset asset);
        int DeleteAsset { get; set; }
        int UpdateAssetQty(int assetQty);
        
    }
}
