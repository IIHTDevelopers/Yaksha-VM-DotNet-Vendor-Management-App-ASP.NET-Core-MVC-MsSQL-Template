using VendorManagementApp.DAL.Interface;
using VendorManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VendorManagementApp.DAL.Repository
{
    public class VendorManagementService : IVendorInterface
    {
        private IVendorRepository _repo;
        public VendorManagementService(IVendorRepository repo)
        {
            this._repo = repo;
        }

        public Vendor AddVendor(Vendor vendor)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Vendor DeleteVendor(int vendorId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Vendor GetVendorById(int vendorId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Vendor UpdateVendor(Vendor vendor)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}