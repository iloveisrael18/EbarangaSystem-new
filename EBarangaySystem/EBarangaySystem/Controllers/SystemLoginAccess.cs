using EBarangaySystem.DatabaseContext;
using EBarangaySystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBarangaySystem.Controllers
{
    public class SystemLoginAccess : Controller
    {

        private readonly ebsDbContext _db;
        public SystemLoginAccess(ebsDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<system_login_access> login = new List<system_login_access>();

            login =  _db.SYSTEM_LOGIN_ACCESS.ToList();

            return View(login);
        }
    }
}
