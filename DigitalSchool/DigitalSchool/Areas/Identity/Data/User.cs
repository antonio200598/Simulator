using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using DigitalSchool.Platform.Entity.Enums;

namespace DigitalSchool.Areas.Identity.Data;

public class User : IdentityUser
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public UserType Type { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }


}

