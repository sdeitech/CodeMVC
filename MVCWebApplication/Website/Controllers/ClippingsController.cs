using Core.Common;
using Core.Domain.Clipping;
using Services.Clipping;
using Website.Common;
using Website.Models;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class ClippingsController : Controller
    {
        private readonly IClipping _clippingService;

        public ClippingsController(IClipping clippingService)
        {
            _clippingService = clippingService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetClipDetailsByName(string clipName)
        {
            var clipDetails = _clippingService.GetClipDetailsFromClipName(clipName);          
            return Json(clipDetails, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllCategory()
        {
            var tags = _clippingService.GetAllCategory();
            return Json(tags, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public string SaveClipsDetails(SaveClipModel clippedDetail)
        {
            var mapper = GenericAutoMapperConfigure.InitializeAutoMapper<SaveClipModel, CabinetSaveClip>();
            var clipInfo = mapper.Map<CabinetSaveClip>(clippedDetail);
            int resultVal = _clippingService.SaveClipDetails(clipInfo);

            string returnVal;
            if (resultVal > 0)
                returnVal = ResponseStatus.Success;
            else
                returnVal = ResponseStatus.Failed;

            return returnVal;
        }
    }
}