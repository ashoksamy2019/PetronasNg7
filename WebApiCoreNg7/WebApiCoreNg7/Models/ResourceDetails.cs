using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreNg7.Models
{
    public class ResourceDetails
    {
        [Key]
        public int ResID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ResouceName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string ResURL { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CreatedDate { get; set; }
    }
}
