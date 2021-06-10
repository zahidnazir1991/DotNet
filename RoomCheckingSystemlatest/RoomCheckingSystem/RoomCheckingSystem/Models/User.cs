using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class User
    {
        [Key]
        public Int64? ID  { get; set; }
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string FirstName { get; set; }
     
        public string LastName { get; set; }
        
        public string UserPassword { get; set; }
        [NotMapped]
        
        [Compare("UserPassword",ErrorMessage = "Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public string dtUpdationDate { get; set; }
        public string dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
        public bool isActive { get; set; }
        public Int64? UserGroup { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? UserType { get; set; }
        public bool isAllowpin { get; set; }
        public string? PinCode { get; set; }


    }
}
