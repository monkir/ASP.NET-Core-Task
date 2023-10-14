using DAL.DB;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ViewLogRepo : Repo, IRepo<ViewLog, int, bool>
    {
        public List<ViewLog> All()
        {
            return db.ViewLogs.Take(1000).ToList();
        }

        public ViewLog Get(int Id)
        {
            return db.ViewLogs.Find(Id);
        }

        public bool Create(ViewLog Obj)
        {
            db.ViewLogs.Add(Obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(int id, ViewLog Obj)
        {
            var ExObj = Get(id);
            db.ViewLogs.Entry(ExObj).CurrentValues.SetValues(Obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ExObj = Get(id);
            db.ViewLogs.Remove(ExObj);
            return db.SaveChanges() > 0;
        }
    }
}
