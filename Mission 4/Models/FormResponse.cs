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
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Director is Required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Year is Required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Rating is Required")]
        public string Rating { get; set; }
        [Required(ErrorMessage = "Edited is Required")]
        public Boolean Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //Build a foreign key relationship
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        public Category Category { get; set; }
    }
}
