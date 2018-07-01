using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp01.Models.Entities
{
    public class Departament
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Description { get; set; }
    }
}