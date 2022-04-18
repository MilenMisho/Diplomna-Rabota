using PlaneTicketsApp.Abstractions;
using PlaneTicketsApp.Data;
using PlaneTicketsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Services
{
    public class BrandService:IBrandService
    {
        private readonly ApplicationDbContext _context;

        public BrandService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Brand GetBrandById(int brandId)
        {
            return _context.Brands.Find(brandId);
        }

        public List<Brand> GetBrands()
        {
            List<Brand> brands = _context.Brands.ToList();
            return brands;
        }

        public List<Plane> GetPlaneByBrand(int brandId)
        {
            return _context.Planes
                  .Where(x => x.BrandId ==
                  brandId)
              .ToList();
        }
    }
}
