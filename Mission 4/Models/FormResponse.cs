using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int FormId { get; set; }


        //prop <tab> <tab> for faster 
        public string Title { get; set; }
        public string Director { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public Boolean Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
