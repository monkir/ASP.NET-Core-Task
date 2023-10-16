using DAL.DB;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ChannelService
    {
        public static List<Channel> All()
        {
            return DataAccess.GetChannel().All().Skip(20).Take(10).ToList();
        }
        public static Channel Get(int Id)
        {
            return DataAccess.GetChannel().Get(Id);
        }
    }
}
