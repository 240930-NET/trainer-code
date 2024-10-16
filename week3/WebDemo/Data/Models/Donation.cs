using System;
using System.Collections.Generic;

namespace WebDemo.Data;

public partial class Donation
{
    public int DonationId { get; set; }

    public double Amount { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
