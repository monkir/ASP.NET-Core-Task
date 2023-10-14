using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class PlayoutFile
{
    public int Id { get; set; }

    public int ChannelId { get; set; }

    public DateTime Date { get; set; }
}
