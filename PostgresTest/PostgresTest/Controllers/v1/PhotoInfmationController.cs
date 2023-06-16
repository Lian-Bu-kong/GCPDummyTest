using Microsoft.AspNetCore.Mvc;
using PostgresTest.Service;
using System.Text.Json;

namespace PostgresTest.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PhotoInfmationController : ControllerBase
    {
        private readonly IPhotoInfmationService _photoInfmationService;
        public PhotoInfmationController(IPhotoInfmationService photoInfmationService)
        {
            _photoInfmationService = photoInfmationService;
        }

        [HttpGet(Name = nameof(GetAllPhotoInfmation))]
        public ActionResult GetAllPhotoInfmation(ApiVersion version)
        {
            var photoInfmations = _photoInfmationService.ReadAllPhotoInfmation();
       
            return Ok(new
            {
                value = photoInfmations,
            });
        }

    }
}
