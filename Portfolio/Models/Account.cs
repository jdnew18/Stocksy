using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models;

public partial class Account
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<Portfolio> Portfolio { get; set; } = new List<Portfolio>();
}
