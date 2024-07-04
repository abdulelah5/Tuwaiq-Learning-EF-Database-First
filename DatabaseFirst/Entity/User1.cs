using System;
using System.Collections.Generic;

namespace DatabaseFirst.Entity;

public partial class User1
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? PhoneNum { get; set; }

    public string? Email { get; set; }

    public int Id { get; set; }
}
