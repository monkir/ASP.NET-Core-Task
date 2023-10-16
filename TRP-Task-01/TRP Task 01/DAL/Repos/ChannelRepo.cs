using DAL.DB;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ChannelRepo : Repo, IRepo<Channel, int, bool>
    {
        public List<Channel> All()
        {
            return db.Channels.ToList();
        }

        public bool Create(Channel Obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Channel Get(int Id)
        {
            return db.Channels.Find((ulong)Id);
        }

        public bool Update(int id, Channel Obj)
        {
            throw new NotImplementedException();
        }
    }
}
