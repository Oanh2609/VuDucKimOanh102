using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050102.Models
{
    [Table("LopHoc102")]
    public class LopHoc102
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLop { get; set; }
        [StringLength(50)]
        public int TenLop { get; set; }
    }
}