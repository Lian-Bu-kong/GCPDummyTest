﻿namespace PostgresTest.Infra
{

    public class PhotoInfmationEntity
    {
        public int UserID { get; set; }
        public string Name { get; set; } = string.Empty;

        public int FileSize { get; set; }

        public DateTime UploadTime { get; set; }
    }
}