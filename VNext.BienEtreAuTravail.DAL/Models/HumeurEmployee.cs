using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VNext.BienEtreAuTravail.DAL.Models.Database
{
    public class HumeurEmployee
    {
        [Key]
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }

        [Key]
        public int IdHumeur { get; set; }
        public Mood HumeurEmp { get; set; }
    }

}
