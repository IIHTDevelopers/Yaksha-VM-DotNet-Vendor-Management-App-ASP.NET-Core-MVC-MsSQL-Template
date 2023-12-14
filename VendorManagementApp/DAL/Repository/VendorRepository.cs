using VendorManagementApp.DAL.Interface;
using VendorManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VendorManagementApp.DAL.Repository
{
    public class VendorRepository : IVendorRepository
    {
        private VendorDbContext _context;
        public VendorRepository(VendorDbContext Context)
        {
            this._context = Context;
        }
      
        public Vendor GetVendorById(int vendorId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Vendor AddVendor(Vendor vendor)
        {
            //write your code here
            throw new NotImplementedException();
        }


        public Vendor UpdateVendor(Vendor updatedVendor)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Vendor DeleteVendor(int vendorId)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
