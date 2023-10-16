using DAL.DB;
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
        public static IRepo<AdLog, int, bool> GetAdLog() { return new AdLogRepo(); }
        public static IRepo<Channel, int, bool> GetChannel() { return new ChannelRepo(); }
        public static IRepo<ViewLog, int, bool> GetViewLog() { return new ViewLogRepo(); }
    }
}
