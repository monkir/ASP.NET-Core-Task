﻿using BLL.DTOs;
using DAL;
using DAL.DB;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ViewLogService
    {
        public static List<ViewLog> All()
        {
            return DataAccess.GetViewLog().All().Skip(20).Take(10).ToList();
        }
        public static ViewLog Get(int Id)
        {
            return DataAccess.GetViewLog().Get(Id);
        }
        // convert List< ViewLogs > to List< ViewLogStatus >
        public static List<ViewLogStatusDTO> VL2VLS(IEnumerable<ViewLog> viewLogs)
        {
            var date = viewLogs.Select(v => DateOnly.FromDateTime(v.StartedWatchingAt.Date));
            var minDate = date.Min();
            var maxDate = date.Max();
            var DistinctDates = date.Distinct();
            var list = new List<ViewLogStatusDTO>();
            var d = minDate;
            int i = 1;
            int ChannelId = viewLogs.FirstOrDefault().ChannelId;
            var ChannelObj = DataAccess.GetChannel().Get(ChannelId);
            while (d < maxDate)
            {
                if (DistinctDates.Contains(d) == false)
                {
                    d = d.AddDays(1);
                    continue;
                }
                var vls = new ViewLogStatusDTO()
                {
                    SerialNo = i++,
                    DateFrom = d,
                    ChannelName = ChannelObj.ChannelName,
                    ChannelID = ChannelId,
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
        public static List<ViewLogStatusDTO> GetListOfViewLogStatus()
        {
            var list = DataAccess.GetViewLog().All();
            var DistinctByChannelAndDate = list.DistinctBy(l => new { l.ChannelId, l.StartedWatchingAt.Day });
            var GroupedByChannel = DistinctByChannelAndDate.OrderBy(d => d.ChannelId).GroupBy(d => d.ChannelId);
            var VLS_List = new List<ViewLogStatusDTO>();
            foreach( var group in GroupedByChannel)
            {
                var ListByChannel = group.Select(g => g);
                VLS_List.AddRange(VL2VLS(ListByChannel));
            }
            int i = 1;
            foreach( var v in VLS_List)
            {
                v.SerialNo = i++;
            }
            return VLS_List.ToList();
        }
    }
}
