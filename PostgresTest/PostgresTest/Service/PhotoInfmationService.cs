using PostgresTest.Infra;
using PostgresTest.Model.Dto;

namespace PostgresTest.Service
{
    public class PhotoInfmationService : IPhotoInformationService
    {
        private DBContext DBContext;
        public PhotoInfmationService(DBContext dbContext)
        {
            DBContext = dbContext;
        }
        public IEnumerable<PhotoInfmationDto> ReadAllPhotoInfmation()
        {
            var photoInfmations = new List<PhotoInfmationDto>();
            var entitys = DBContext.PhotoInfmation.ToList();
            foreach (var entity in entitys)
            {
                var dto = new PhotoInfmationDto()
                {
                    UserID = entity.UserID,
                    FileSize = entity.FileSize,
                    Name = entity.Name,
                    UploadTime = DateTime.Now,
                };
                photoInfmations.Add(dto);
            }
            return photoInfmations;
        }
    }
}
