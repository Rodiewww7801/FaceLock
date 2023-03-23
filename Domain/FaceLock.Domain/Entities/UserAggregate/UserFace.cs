﻿namespace FaceLock.Domain.Entities.UserAggregate
{
    public class UserFace
    {
        public int Id { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageMimeType { get; set; }
        public string? UserId { get; set; }

        public User? User { get; set; }
    }
}
