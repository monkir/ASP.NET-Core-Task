using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class ViewLogsArchive
{
    public ulong Id { get; set; }

    public int ViewLogId { get; set; }

    public int ChannelId { get; set; }

    public int UserId { get; set; }

    public DateTime StartedWatchingAt { get; set; }

    public DateTime? FinishedWatchingAt { get; set; }

    public double? DurationMinute { get; set; }
}
