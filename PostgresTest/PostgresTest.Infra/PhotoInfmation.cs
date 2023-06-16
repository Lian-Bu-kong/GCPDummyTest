using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PostgresTest.Infra
{
    
    public class PhotoInfmation
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; } = string.Empty;

        public int FileSize { get; set; }

        public DateTime UploadTime { get; set; }
    }
}