using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class RawRequest
{
    public int Id { get; set; }

    public string ChannelId { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public string? Start { get; set; }

    public string? Finish { get; set; }

    public string? People { get; set; }

    public string? Offline { get; set; }

    public string? Temp { get; set; }

    public string? Error { get; set; }

    public string ServerTime { get; set; } = null!;

    public string? TimeStamp { get; set; }
}
