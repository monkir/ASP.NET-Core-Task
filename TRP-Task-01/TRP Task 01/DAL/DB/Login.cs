using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Login
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Verified { get; set; }

    public string Role { get; set; } = null!;

    public int Active { get; set; }

    public int TryTime { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }
}
