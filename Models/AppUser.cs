using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace App.Models
{

    public class AppUser : IdentityUser
    {

        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public Guid Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string HomeAdress { get; set; }

        // [Required]       
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}