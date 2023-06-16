namespace PostgresTest.Model.Dto
{
    public class PhotoInfmation
    {
        public int UserID { get; set; }
        public string Name { get; set; } = string.Empty;

        public int FileSize { get; set; }

        public DateTime UploadTime { get; set; }
    }
}
