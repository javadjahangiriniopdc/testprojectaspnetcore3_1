using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcore3_1.Data
{
    public class Kala
    {
        [Key]
        public int KalaId { get; set; }
        [Required]
        public string Kalaname { get; set; }
        public int KalaPrice { get; set; }

    }
}
