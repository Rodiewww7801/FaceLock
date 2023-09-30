﻿namespace FaceLock.Domain.Entities.DoorLockAggregate
{
    /// <summary>
    /// Сlass represents a door lock security information.
    /// </summary>
    public class DoorLockSecurityInfo
    {
        public int Id { get; set; }
        public int DoorLockId { get; set; }
        public string SerialNumber { get; set; }

        public DoorLock? DoorLock { get; set; }
    }
}
