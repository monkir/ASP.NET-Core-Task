using BLL.DTOs;
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

        // convert List< AdLogs > to List< AdLogStatus >
        public static List<AdLogStatusDTO> VL2VLS(IEnumerable<AdLog> AdLogs)
        {
            var date = AdLogs.Select(v => DateOnly.FromDateTime(v.AdDate.Date));
            var minDate = date.Min();
            var maxDate = date.Max();
            var DistinctDates = date.Distinct();
            var list = new List<AdLogStatusDTO>();
            var d = minDate;
            int i = 1;
            int ChannelId = AdLogs.FirstOrDefault().ChannelId;
            var ChannelObj = DataAccess.GetChannel().Get(ChannelId);
            while (d < maxDate)
            {
                if (DistinctDates.Contains(d) == false)
                {
                    d = d.AddDays(1);
                    continue;
                }
                var vls = new AdLogStatusDTO()
                {
                    SerialNo = i++,
                    DateFrom = d,
                    ChannelID = ChannelId,
                    ChannelName = ChannelObj.ChannelName,
                    DateTo = d,
                };
                d = d.AddDays(1);
                while (DistinctDates.Contains(d))
                {
                    vls.DateTo = d;
                    d = d.AddDays(1);
                }
                list.Add(vls);
            }
            return list;
        }
        public static List<AdLogStatusDTO> GetListOfAdLogStatus()
        {
            var list = DataAccess.GetAdLog().All();
            var DistinctByChannelAndDate = list.DistinctBy(l => new { l.ChannelId, l.AdDate.Day });
            var GroupedByChannel = DistinctByChannelAndDate.OrderBy(d => d.ChannelId).GroupBy(d => d.ChannelId);
            var VLS_List = new List<AdLogStatusDTO>();
            foreach (var group in GroupedByChannel)
            {
                var ListByChannel = group.Select(g => g);
                VLS_List.AddRange(VL2VLS(ListByChannel));
            }
            int i = 1;
            foreach (var v in VLS_List)
            {
                v.SerialNo = i++;
            }
            return VLS_List.ToList();
        }
    }
}
