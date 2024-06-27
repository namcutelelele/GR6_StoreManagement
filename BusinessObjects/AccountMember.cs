using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class AccountMember
{
    public int MemberId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;
}
