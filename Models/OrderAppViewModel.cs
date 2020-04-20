using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using testprojectaspnetcore3_1.Data;

namespace testprojectaspnetcore3_1.Models
{
    public class OrderAppViewModel
    {
        public int Id { get; set; }

        
        public CustomerViewModel Customer { get; set; }
        public string CustomerId { get; set; }


     
        public DetailsKalaViewModel Kala { get; set; }
        public int KalaId { get; set; }


        public IEnumerable<SelectListItem> CustomerSelectListItems { get; set; }
        public IEnumerable<SelectListItem> KalaSelectListItems { get; set; }


        public int tedad { get; set; }
        public int kalaprice { get; set; }
        public int kalaAll { get; set; }
        public string DataSabt { get; set; }
        public string TimeSabt { get; set; }
    }
}
