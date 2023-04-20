﻿using FaceLock.Domain.Entities.PlaceAggregate;
using FaceLock.Domain.Repositories.PlaceRepository;

namespace FaceLock.EF.Repositories
{
    public class PlaceRepository : Repository<Place>, IPlaceRepository
    {
        public PlaceRepository(FaceLockDbContext context) : base(context)
        {
        }
    }
}
