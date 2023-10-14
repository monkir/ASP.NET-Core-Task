using DAL;
using DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdLogService
    {
        public static List<AdLog> All()
        {
            return DataAccess.GetAdLog().All().Skip(20).Take(10).ToList();
        }
        public static AdLog Get(int Id)
        {
            return DataAccess.GetAdLog().Get(Id);
        }
        public static DateOnly GetMinDate()
        {
            var AdDate = DataAccess.GetAdLog().All().Select(a => a.AdDate).Min();
            return DateOnly.FromDateTime(AdDate);
        }
        public static DateOnly GetMaxDate()
        {
            var AdDate = DataAccess.GetAdLog().All().Select(a => a.AdDate).Max();
            return DateOnly.FromDateTime(AdDate);
        }
        public static List<DateOnly> GetDates()
        {
            var AdDates = DataAccess.GetAdLog().All().Select(a => DateOnly.FromDateTime(a.AdDate)).Distinct();
            return AdDates.ToList();
        }
    }
}
