using Core.Domain.Clipping;
using System.Collections.Generic;

namespace Core.Data
{
    public interface IClippingRepository
    {
        List<ClippingTags> GetAllTags();
        List<ClippingTags> GetAllCategory();
        int SaveClipDetails(CabinetSaveClip clipData);
        CabinetSaveClip GetClipDetailsFromClipName(string clipName);
    }
}
