using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            if (Convert.ToInt32(obj.DepartmentId) != 1 || Convert.ToInt32(obj.DepartmentId) != 2 || Convert.ToInt32(obj.DepartmentId) != 3)
            {
                obj.DepartmentId = 0b100;
            }
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
