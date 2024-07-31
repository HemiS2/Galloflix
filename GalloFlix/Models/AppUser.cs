using System.ComponentModel.Dataannotations;
using System.ComponentModel.Dataannotations.scheme;
using Microsoft.AspNetCore.Identity;

namespace GalloFlix.Models;

[Table("AppUser")]
    public class AppUser
    {
        [Key]
        public string AppUserId { get; set;}
        [foreignKey("AppUserId")]
        public IdentityUser UserAccount { get; set; }
        
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [DataType(DataType.Data)]
        [Required]
        public Datatime Birthday { get; set; }
        [StringLength(300)]
        public string Photo {get; set; }
    }
