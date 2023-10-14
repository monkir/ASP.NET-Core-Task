using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class ViewLog
{
    public ulong Id { get; set; }

    public int ChannelId { get; set; }

    public int UserId { get; set; }

    public DateTime StartedWatchingAt { get; set; }

    public DateTime? FinishedWatchingAt { get; set; }

    public double? DurationMinute { get; set; }

    public int System { get; set; }

    public int Universe { get; set; }

    public int? CategoryId { get; set; }
}
