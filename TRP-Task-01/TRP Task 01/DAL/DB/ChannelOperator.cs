using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class ChannelOperator
{
    public ulong Id { get; set; }

    public int OperatorId { get; set; }

    public int ChannelId { get; set; }

    public int ChannelNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
