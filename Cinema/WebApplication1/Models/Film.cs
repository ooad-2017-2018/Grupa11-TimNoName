using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Naziv filma")]
        public String Naslov { get; set; }
        [Required]
        [DisplayName("Trailer")]
        public String Trailer { get; set; }
        [Required]
        [DisplayName("Redatelj")]

        public String Redatelj { get; set; }

        [Required]
        [DisplayName("Žanr")]
        public String Zanr { get; set; }

        public int Ocjena { get; set; }
    }
}