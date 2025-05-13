using Core.Domain.Clipping;
using System.Collections.Generic;

namespace Services.Clipping
{
    public interface IClipping
    {
        List<ClippingTags> GetAllTags();
        List<ClippingTags> GetAllCategory();
        int SaveClipDetails(CabinetSaveClip clipData);
        CabinetSaveClip GetClipDetailsFromClipName(string clipName);
    }
}
