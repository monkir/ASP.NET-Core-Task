using DAL.DB;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AdLogRepo : Repo, IRepo<AdLog, int, bool>
    {
        public List<AdLog> All()
        {
            return db.AdLogs.ToList();
        }

        public AdLog Get(int Id)
        {
            return db.AdLogs.Find(Id);
        }

        public bool Create(AdLog Obj)
        {
            db.AdLogs.Add(Obj); 
            return db.SaveChanges() > 0;
        }

        public bool Update(int id, AdLog Obj)
        {
            var ExObj = Get(id);
            db.AdLogs.Entry(ExObj).CurrentValues.SetValues(Obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ExObj = Get(id);
            db.AdLogs.Remove(ExObj);
            return db.SaveChanges() > 0;
        }
    }
}
