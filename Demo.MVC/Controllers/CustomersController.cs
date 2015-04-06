using Demo.MVC.CustomerService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Demo.MVC.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            CustomerServiceClient client = new CustomerServiceClient();
            List<Customer_> customers = client.getCustomers().ToList<Customer_>();
            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_ customer = new CustomerServiceClient().getCustomer(id.Value );
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Customers/Create
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Surname,DateOfBirth,CreditLimit,Balance,ContactNo,EmailAddress")] Customer_ customer)
        {
            string errMsg="";
            if (ModelState.IsValid)
            {               
                if (new CustomerServiceClient().AddCustomer(customer, out errMsg))
                {
                    return RedirectToAction("Index");
                }
            }
            //handle  error message
            ModelState.AddModelError("Error", errMsg);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_ customer = new CustomerServiceClient().getCustomer(id.Value);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //POST: Customers/Edit/5
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Surname,DateOfBirth,CreditLimit,Balance,ContactNo,EmailAddress")] Customer_ customer)
        {
            string errMsg="";
            if (ModelState.IsValid)
            {
                if (new CustomerServiceClient().UpdateCustomer(customer, out errMsg))
                {
                    return RedirectToAction("Index");
                }
            }
            //handle  error message
            ModelState.AddModelError("Error", errMsg);
            return View(customer);
        }

        //GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_ customer = new CustomerServiceClient().getCustomer(id.Value);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string errMsg;
             CustomerServiceClient client = new CustomerServiceClient();
            Customer_ customer = client.getCustomer(id);
            if (client.DeleteCustomer(customer, out errMsg))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(customer);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
              
            }
            base.Dispose(disposing);
        }

    }
}
