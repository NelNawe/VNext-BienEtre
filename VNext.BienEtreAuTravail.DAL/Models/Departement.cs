using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNext.BienEtreAuTravail.DAL.Models.Database
{
    public class Departement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepartement { get; set; }
        public string NomDepartement { get; set; }
        public string NomResponsable { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public Employee Employee { get; set; }



    }
}