using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models;

public partial class Stock
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "INT")]
    public int PortfolioId { get; set; }

    [Column(TypeName = "NUMERIC")]
    public decimal Price { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("PortfolioId")]
    [InverseProperty("Stock")]
    public virtual Portfolio Portfolio { get; set; } = null!;
}
