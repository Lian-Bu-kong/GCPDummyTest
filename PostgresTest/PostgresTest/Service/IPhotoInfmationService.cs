using PostgresTest.Model.Dto;

namespace PostgresTest.Service
{
    public interface IPhotoInfmationService
    {
        IEnumerable<PhotoInfmationDto> ReadAllPhotoInfmation();
    }
}
