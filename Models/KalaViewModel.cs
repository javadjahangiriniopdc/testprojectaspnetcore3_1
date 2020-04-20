using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcore3_1.Models
{
    public class DetailsKalaViewModel
    {
    
        public int KalaId { get; set; }
        public string Kalaname { get; set; }
        public int KalaPrice { get; set; }
    }

    public class CreateKalaViewModel
    {
        [Required]
        public string Kalaname { get; set; }
        public int KalaPrice { get; set; }
    }

}
