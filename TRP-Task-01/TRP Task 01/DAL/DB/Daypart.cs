using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Daypart
{
    public int ChannelId { get; set; }

    public DateTime Day { get; set; }

    public int TimeRange { get; set; }

    public string Data { get; set; } = null!;

    public string Type { get; set; } = null!;
}
