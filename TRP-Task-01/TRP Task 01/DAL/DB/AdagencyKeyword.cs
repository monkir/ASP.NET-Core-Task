using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class AdagencyKeyword
{
    public int Id { get; set; }

    public string Keyword { get; set; } = null!;

    public string AgencyId { get; set; } = null!;
}
