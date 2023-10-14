using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Token
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Value { get; set; } = null!;

    public string Token1 { get; set; } = null!;
}
