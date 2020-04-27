using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcore3_1.Models
{
    public class DetailsKalaViewModel
    {
    
        [Display(Name = "کد کالا")]
        public int KalaId { get; set; }
        [Display(Name = "نام کالا")]
        public string Kalaname { get; set; }
        [Display(Name = "قیمت کالا")]
        public int KalaPrice { get; set; }
    }

    public class CreateKalaViewModel
    {
        [Required]
        [Display(Name = "نام کالا")]
        public string Kalaname { get; set; }
        [Display(Name = "قیمت کالا")]
        public int KalaPrice { get; set; }
    }

}
