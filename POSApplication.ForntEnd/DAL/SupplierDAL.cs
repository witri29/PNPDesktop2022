using POSApplication.ForntEnd.Models;
using POSApplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.ForntEnd.DAL
{
    public class SupplierDAL
    {
        private ApplicationDbContext _dbContext;
        public SupplierDAL()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Supplier> GetAll()
        {
            var suppliers = _dbContext.Suppliers.OrderBy(s => s.Nama).ToList();
            return suppliers;
        }

        public List<Supplier> GetByNama(string nama)
        {
            var results = _dbContext.Suppliers.Where(s => s.Nama.Contains(nama))
                .OrderBy(s => s.Nama).ToList();
            return results;
        }
    }
}
