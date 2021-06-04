using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagment.Models
{
    public class Project
    {
        public Project() { }


        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        [Required]
        public int EstimateInDays { get; set; }
        [Required]
        public DateTime Deadline { get; set; }


    }




}
