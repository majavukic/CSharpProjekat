using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS322_PZ_VukicMaja3683.Enums;

namespace CS322_PZ_VukicMaja3683.Models
{
    public class Korisnik
    {
        [Key]
        [Column("KorisnikId")]
        public int KorisnikId { get; set; }


        [Column("Username")]
        public string KorisnickoIme { get; set; }


        [Column(TypeName = "varchar(30)")]
        public string Lozinka { get; set; }

        [Column("Clanarina")]
        public Boolean Clanarina { get; set; }

        public KorisnikRola KorisnikRola { get; set; }

        public List<Film> KorisnikFilmovi { get; set; }


    }
}

