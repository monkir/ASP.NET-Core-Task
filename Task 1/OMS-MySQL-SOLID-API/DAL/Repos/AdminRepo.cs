using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos
{
    internal class AdminRepo :Repo, IRepo<Admin, int, bool>
    {
        public bool Add(Admin Obj)
        {
            Db.Admins.Add(Obj);
            return Db.SaveChanges() > 0;
        }

        public List<Admin> All()
        {
            return Db.Admins.Include(a => a.Employees).ToList();
        }

        public bool Delete(int Id)
        {
            var ExObj = Get(Id);
            if (ExObj == null) { return false; }
            Db.Admins.Remove(ExObj);
            return Db.SaveChanges() > 0;
        }

        public Admin Get(int Id)
        {
            return Db.Admins.Include(a => a.Employees).Where(a => a.Id == Id).SingleOrDefault();
        }

        public bool Update(Admin Obj)
        {
            Db.Admins.Update(Obj);
            return Db.SaveChanges() > 0;
        }
    }
}
