using System;
using System.Collections.Generic;

namespace WebDemo.Data;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<Donation> Donations { get; set; } = new List<Donation>();
}
