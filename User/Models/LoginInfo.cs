using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace User.Models;

public partial class LoginInfo
{
    [Key]
    [Column(TypeName = "INT")]
    public int Id { get; set; }

    [Column(TypeName = "VARCHAR(255)")]
    public string Email { get; set; } = null!;

    [Column(TypeName = "VARCHAR(255)")]
    public string Password { get; set; } = null!;

    [Column(TypeName = "DATETIME2")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "DATETIME2")]
    public DateTime? UpdatedDate { get; set; }

    [InverseProperty("LoginInfo")]
    public virtual PersonalInfo PersonalInfo { get; set; } = null!;
}
