using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ItemsController : Controller
  {
    private readonly HairSalonContext _db;

    public ItemsController(HairSalonContext db)
    {
      _db = db;
    }

  }
}