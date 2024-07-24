using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models;

public partial class Portfolio
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "INT")]
    public int AccountId { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime? UpdatedDate { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("Portfolio")]
    public virtual Account Account { get; set; } = null!;

    [InverseProperty("Portfolio")]
    public virtual ICollection<Stock> Stock { get; set; } = new List<Stock>();
}
