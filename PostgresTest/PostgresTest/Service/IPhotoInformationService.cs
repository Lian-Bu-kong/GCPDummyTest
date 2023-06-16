using PostgresTest.Model.Dto;

namespace PostgresTest.Service
{
    public interface IPhotoInformationService
    {
        IEnumerable<PhotoInfmationDto> ReadAllPhotoInfmation();
    }
}
