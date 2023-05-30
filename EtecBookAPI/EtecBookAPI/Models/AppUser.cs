using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecBookAPI.Models;

    [Table("Users")]
    public class AppUser
    {
        [Key]
        public Guid Id{ get; set; }

        [Required]
        [StringLength(60)]

        public int Name { get; set; }

        
        [Required]
        [StringLength(20, MinimumLength = 3)]

        public int UserName { get; set; }

        [Required]        

        public int Password { get; set; }

        public string Token { get; set; }

        [Required]
        [StringLength(20)]

        public string Role { get; set; }

        [Required]
        [StringLength(100)]

        public string Email { get; set; }

        [StringLength(300)]

        public string ProfilePicture  { get; set; }        

    }
