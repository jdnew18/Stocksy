using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace User.Models;

public partial class PersonalInfo
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "INT")]
    public int LoginInfoId { get; set; }

    [Column(TypeName = "INT")]
    public int PhoneNumber { get; set; }

    [Column(TypeName = "VARCHAR(255)")]
    public string? FirstName { get; set; }

    [Column(TypeName = "VARCHAR(255)")]
    public string? LastName { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime? UpdatedDate { get; set; }

    [ForeignKey("LoginInfoId")]
    [InverseProperty("PersonalInfo")]
    public virtual LoginInfo LoginInfo { get; set; } = null!;
}
