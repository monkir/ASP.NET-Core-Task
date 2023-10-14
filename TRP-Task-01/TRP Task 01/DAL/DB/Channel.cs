using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Channel
{
    public ulong Id { get; set; }

    public string? TmpChannelName { get; set; }

    public string? ChannelName { get; set; }

    public string Address { get; set; } = null!;

    public string? TmpLogo { get; set; }

    public string? Logo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
