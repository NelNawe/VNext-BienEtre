using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNext.BienEtreAuTravail.DAL.Models.Database
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmployee { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public bool IsDepartmentManager { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public int? IdDepartement { get; set; }
        public Departement Departement { get; set; }

        public Commentaire Commentaire { get; set; }
        IList<HumeurEmployee> HumeurEmployee { get; set; }
        
        public Employee()
        {
            this.Created_at = DateTime.Now;

        }
    }
}