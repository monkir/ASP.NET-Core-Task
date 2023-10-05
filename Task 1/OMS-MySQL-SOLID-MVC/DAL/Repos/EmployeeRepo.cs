using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo:Repo, IRepo<Employee, int, bool>
    {
        public bool Add(Employee Obj)
        {
            Db.Employees.Add(Obj);
            return Db.SaveChanges() > 0;
        }

        public List<Employee> All()
        {
            return Db.Employees.Include(e => e.Admin).ToList();
        }

        public bool Delete(int Id)
        {
            var ExObj = Get(Id);
            if (ExObj == null) { return false; }
            Db.Employees.Remove(ExObj);
            return Db.SaveChanges() > 0;
        }

        public Employee Get(int Id)
        {
            return Db.Employees.Include(e => e.Admin).Where(a => a.Id == Id).SingleOrDefault();
        }

        public bool Update(Employee Obj)
        {
            Db.Employees.Update(Obj);
            return Db.SaveChanges() > 0;
        }
    }
}
