using Core.Data;
using Core.Domain.Clipping;
using System;
using System.Collections.Generic;

namespace Data.Repositories.Clipping
{
    public class ClippingRepository : IClippingRepository
    {
        public List<ClippingTags> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public List<ClippingTags> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public CabinetSaveClip GetClipDetailsFromClipName(string clipName)
        {
            throw new NotImplementedException();
        }

        public int SaveClipDetails(CabinetSaveClip clipData)
        {
            throw new NotImplementedException();
        }
    }
}
