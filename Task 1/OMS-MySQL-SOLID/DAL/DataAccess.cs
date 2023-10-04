using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Admin, int, bool> AdminRepo()
        {
            return new AdminRepo();
        }
        public static IRepo<Employee, int, bool> EmployeeRepo()
        {
            return new EmployeeRepo();
        }
    }
}
