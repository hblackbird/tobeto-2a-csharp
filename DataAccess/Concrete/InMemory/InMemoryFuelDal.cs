﻿using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryFuelDal : InMemoryEntityRepositoryBase<Fuel, int>, IFuelDal
{
    protected override int generateId()
    {
        int id = _entities.Count == 0 ? 1: _entities.Max(e=>e.Id)+1;
        return id;
    }
}
