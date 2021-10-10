using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Contacts {

    public class ContactModel 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        // [Display(Name = "Địa chỉ email")]
        public string Email { get; set; }

        [StringLength(50)]
        [Phone]
        [Required]
        public string Phone { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }

        [Display(Name = "Date")]
        // [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateSent { get; set; }

        
    }

}