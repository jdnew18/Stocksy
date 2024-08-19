using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Stocksy.Stock.Models;

public partial class Quote
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "INT")]
    public int StockId { get; set; }

    [Column(TypeName = "NUMERIC")]
    public decimal Value { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("StockId")]
    [InverseProperty("Quote")]
    public virtual Stock Stock { get; set; } = null!;
}
