using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Account.Models;

public partial class Account
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "INT")]
    public int UserId { get; set; }

    [Column(TypeName = "INT")]
    public int AccountType { get; set; }

    [Column(TypeName = "NUMERIC")]
    public decimal Amount { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime? UpdatedDate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Account")]
    public virtual User User { get; set; } = null!;
}
