using Microsoft.AspNetCore.Mvc;
using PostgresTest.Service;

namespace PostgresTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoInfmationController : ControllerBase
    {
        private readonly IPhotoInformationService _photoInformationService;
        public PhotoInfmationController(IPhotoInformationService photoInfmationService)
        {
            _photoInformationService = photoInfmationService;
        }
        public ActionResult Get()
        {
            var photoInfmations = _photoInformationService.ReadAllPhotoInfmation();

            return Ok(new
            {
                value = photoInfmations,
            });
        }

    }
}
