using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class ChannelPackage
{
    public ulong Id { get; set; }

    public int ChannelId { get; set; }

    public int PackageId { get; set; }

    public string ChannelNumber { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
