﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Homestay.Application.Common.Interfaces;
using Homestay.Domain.Entities;
using Homestay.Infrastructure.Data;

namespace Homestay.Infrastructure.Repository
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        private readonly ApplicationDbContext _db;

        public AmenityRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        
        public void Update(Amenity entity)
        {
            _db.Amenities.Update(entity);
        }
    }
}
