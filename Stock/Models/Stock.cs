using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Stocksy.Stock.Models;

public partial class Stock
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "VARCHAR(4)")]
    public string TickerSymbol { get; set; } = null!;

    [Column(TypeName = "VARCHAR(100)")]
    public string CompanyName { get; set; } = null!;

    [InverseProperty("Stock")]
    public virtual ICollection<Quote> Quote { get; set; } = new List<Quote>();
}
