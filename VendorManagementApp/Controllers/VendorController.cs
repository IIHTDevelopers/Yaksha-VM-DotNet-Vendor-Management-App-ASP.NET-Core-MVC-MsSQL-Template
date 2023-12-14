using Microsoft.AspNetCore.Mvc;
using VendorManagementApp.DAL.Interface;
using VendorManagementApp.Models;

namespace VendorManagementApp.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorInterface _vendorRepository;

        public VendorController(IVendorInterface vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        // GET: /Vendor/Index
        public IActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Vendor/Details/{id}
        public IActionResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Vendor/Create
        public IActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Vendor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendor vendor)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Vendor/Edit/{id}
        public IActionResult Edit(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Vendor/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Vendor updatedVendor)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Vendor/Delete/{id}
        public IActionResult Delete(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Vendor/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
