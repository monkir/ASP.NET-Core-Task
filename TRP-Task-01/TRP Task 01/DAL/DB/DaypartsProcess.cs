using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class DaypartsProcess
{
    public int Id { get; set; }

    public int ChannelId { get; set; }

    public DateTime Day { get; set; }

    public int TimeRange { get; set; }

    public string Type { get; set; } = null!;
}
