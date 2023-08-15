using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_VukicMaja3683.Models
{
    public class Film
    {
        [Key]
        [Column("FilmId")]
        public int FilmId { get; set; }

        [Column("Naziv")]
        public string Naziv { get; set; }

        [Column("Reditelj")]
        public string Reditelj { get; set; }


        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }


    }
}

