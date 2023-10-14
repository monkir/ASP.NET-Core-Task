using DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ViewLogSepcialRepo:Repo
    {
        public List<DateOnly> GetDistinctDate()
        {
            var DistinctDate = db.ViewLogs.Select(v => v.StartedWatchingAt.Date).Distinct().ToList();
            return DistinctDate.Select(d => DateOnly.FromDateTime(d)).ToList();
        }
        public List<ViewLog> GetDistTinctByChannelAndDate()
        {
            //var DistinctPlace = db.ViewLogs.GroupBy(v => new {v.ChannelId, v.StartedWatchingAt.Date}).ToList();
            //var DistTinctByChannelAndDate = db.ViewLogs.DistinctBy(v => new { v.ChannelId, v.StartedWatchingAt }).Take(10).ToList();
            var list = db.ViewLogs.Where(l => l.StartedWatchingAt.Year.Equals(2023)).ToList();
            var DistTinctByChannelAndDate = list.DistinctBy(v => new {v.ChannelId, v.StartedWatchingAt.Date});        
            return DistTinctByChannelAndDate.ToList();
        }
        public List<int> GetDistinctChannels()
        {
            var DistinctChannels = db.ViewLogs.Select(v => v.ChannelId).Distinct().ToList();
            return DistinctChannels;
        }
        public DateOnly GetMinDate()
        {
            var minDateTime = db.ViewLogs.Select(v => v.StartedWatchingAt).Min();
            var minDate = DateOnly.FromDateTime(minDateTime);
            return minDate;
        }
        public DateOnly GetMaxDate()
        {
            var maxDateTime = db.ViewLogs.Select(v => v.StartedWatchingAt).Max();
            var maxDate = DateOnly.FromDateTime(maxDateTime);
            return maxDate;
        }
    }
}
