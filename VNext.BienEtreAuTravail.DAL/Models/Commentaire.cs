using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNext.BienEtreAuTravail.DAL.Models.Database
{
    public class Commentaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCommentaire { get; set; }
        public string Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public int CommentOfEmployee { get; set; }
        public Employee Employee { get; set; }
    }
   
}