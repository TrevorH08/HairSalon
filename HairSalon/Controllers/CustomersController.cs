using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class CustomersController : Controller
  {
    private readonly HairSalonContext _db;

    public CustomersController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Customer> model = _db.Customers.Include(customer => customer.Stylist).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Customer customer)
    {
      _db.Customers.Add(customer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Customer thisCustomer = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
      return View(thisCustomer);
    }

    public ActionResult Edit(int id)
    {
      var thisCustomer = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(thisCustomer);
    }

    [HttpPost]
    public ActionResult Edit(Customer customer)
    {
      _db.Entry(customer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCustomer = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
      return View(thisCustomer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCustomer = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
      _db.Customers.Remove(thisCustomer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}